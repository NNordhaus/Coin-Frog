using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinFrog.Models
{
    public class RecurringTransaction
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                BaseTransaction.RecurrenceName = value;
            }
        }
        public Transaction BaseTransaction { get; set; }
        public DateTime Until { get; set; }
        public int Num { get; set; }
        public PeriodType Every { get; set; }
        public List<int> On { get; set; }

        public ForecastAlgorithm Algo { get; set; }
        public int ForecastParam { get; set; }
        public decimal ForecastPaddingPct { get; set; }

        public RecurringTransaction()
        {
            // Set up some defaults
            Num = 1;
            Every = PeriodType.Months;
            BaseTransaction = new Transaction();
            On = new List<int>();
        }

        public IList<Transaction> GenerateToDate(List<Transaction> previousTransactions, DateTime end)
        {
            if (BaseTransaction.Date >= end)
            {
                throw new ArgumentException("Start date must be before End date", "End");
            }

            if (Num < 1)
            {
                throw new ArgumentException("Num must be a positive Number", "Num");
            }

            var results = new List<Transaction>();

            switch (Every)
            {
                case PeriodType.Days:
                    {
                        DateTime current = BaseTransaction.Date;
                        while (current <= end)
                        {
                            var newTrans = BaseTransaction.Clone();
                            newTrans.Date = current;
                            results.Add(newTrans);
                            current = current.AddDays(Num);
                        }
                        break;
                    }
                case PeriodType.Weeks:
                    {
                        if (On == null || On.Count == 0)
                        {
                            throw new ArgumentException("must have at least one weekday selected", "On");
                        }
                        DateTime current = BaseTransaction.Date;
                        while (current <= end)
                        {
                            foreach (int dayOfWeek in On)
                            {
                                var newTrans = BaseTransaction.Clone();
                                newTrans.Date = current;
                                results.Add(newTrans);
                            }

                            current = current.AddDays(Num * 7);
                        }
                        break;
                    }
                case PeriodType.Months:
                    {
                        if (On == null || On.Count == 0)
                        {
                            throw new ArgumentException("must have at least one day of month selected", "On");
                        }

                        DateTime current = BaseTransaction.Date;
                        while (current <= end)
                        {
                            foreach (int dayOfMonth in On)
                            {
                                var newTrans = BaseTransaction.Clone();
                                newTrans.Date = new DateTime(current.Year, current.Month, dayOfMonth);
                                results.Add(newTrans);
                            }

                            current = current.AddMonths(Num);
                        }

                        break;
                    }
                case PeriodType.Years:
                    {
                        if (On == null || On.Count == 0)
                        {
                            throw new ArgumentException("must have at least one day of year selected", "On");
                        }

                        DateTime current = BaseTransaction.Date;
                        while (current <= end)
                        {
                            foreach (int dayOfYear in On)
                            {
                                var newTrans = BaseTransaction.Clone();
                                newTrans.Date = new DateTime(current.Year, 1, 1).AddDays(dayOfYear - 1);
                                results.Add(newTrans);
                            }

                            current = current.AddYears(Num);
                        }

                        break;
                    }
            }

            return results;
        }

        private decimal ForecastAmount(List<Transaction> previousTransactions)
        {
            if(previousTransactions == null || previousTransactions.Count == 0)
            {
                return ApplyPadding(BaseTransaction.Amount);
            }

            return ApplyPadding(BaseTransaction.Amount);
        }

        public decimal ApplyPadding(decimal amount)
        {
            return amount * (1m + (ForecastPaddingPct / 100m));
        }
    }

    public enum ForecastAlgorithm
    {
        Fixed,
        Mean,
        Median,
        Min,
        Max
    }
}