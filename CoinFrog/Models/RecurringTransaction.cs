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
            }

            return results;
        }

        public System.Windows.Forms.TextBox Name { get; set; }
    }
}
