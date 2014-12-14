using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinFrog.Models
{
    public class RecurringTransaction
    {
        public string Name { get; set; }
        public Transaction BaseTransaction { get; set; }
        public int Num { get; set; }
        public EveryType Every { get; set; }
        public List<int> On { get; set; }

        public IList<Transaction> GenerateToDate(DateTime end)
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
                case EveryType.Day:
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
                case EveryType.Week:
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
                case EveryType.Month:
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
                case EveryType.Year:
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
    }
}