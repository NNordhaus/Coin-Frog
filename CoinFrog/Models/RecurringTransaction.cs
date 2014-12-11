using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoinFrog.Models
{
    public class RecurringTransaction
    {
        public IList<Transaction> GenerateToDate(DateTime start, int num, EveryType every, List<int> on, DateTime end, Transaction trans)
        {
            if (start >= end)
            {
                throw new ArgumentException("start date must be before end date", "end");
            }

            if (num < 1)
            {
                throw new ArgumentException("num must be a positive number", "num");
            }

            var results = new List<Transaction>();

            switch (every)
            {
                case EveryType.Day:
                    {
                        DateTime current = start;
                        while (current <= end)
                        {
                            var newTrans = trans.Clone();
                            newTrans.Date = current;
                            results.Add(newTrans);
                            current = current.AddDays(num);
                        }
                        break;
                    }
                case EveryType.Week:
                    {
                        if (on == null || on.Count == 0)
                        {
                            throw new ArgumentException("must have at least one weekday selected", "on");
                        }
                        DateTime current = start;
                        while (current <= end)
                        {
                            foreach (int dayOfWeek in on)
                            {
                                var newTrans = trans.Clone();
                                newTrans.Date = current;
                                results.Add(newTrans);
                            }

                            current = current.AddDays(num * 7);
                        }
                        break;
                    }
                case EveryType.Month:
                    {
                        if (on == null || on.Count == 0)
                        {
                            throw new ArgumentException("must have at least one day of month selected", "on");
                        }

                        DateTime current = start;

                        // Add days until we are the at ON date
                        //while(current.Day < on[0])
                        //{
                        //    current = current.AddDays(1);
                        //}

                        while (current <= end)
                        {
                            foreach (int dayOfMonth in on)
                            {
                                var newTrans = trans.Clone();
                                newTrans.Date = new DateTime(current.Year, current.Month, dayOfMonth);
                                results.Add(newTrans);
                            }

                            current = current.AddMonths(num);
                        }

                        break;
                    }
            }

            return results;
        }

        public string Name { get; set; }
    }
}
