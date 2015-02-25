using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;

namespace CoinFrog.Models
{
    public class Ledger
    {
        public string Name { get; set; }

        public List<Transaction> Transactions { get; private set; }
        public List<RecurringTransaction> RecurringTransactions { get; set; }
        public List<Status> Statuses { get; set; }
        public int DaysToForecast { get; set; }
        public int DaysToCalculate { get; set; }
        public Ledger()
        {
            Transactions = new List<Transaction>();
            RecurringTransactions = new List<RecurringTransaction>();
            Statuses = new List<Status>();

            // Defaults:
            DaysToForecast = 365;
            DaysToCalculate = 92;
            Statuses.Add(new Status() { Name = "ToDo", BackColor = 0xE67086, ForeColor = 0x700116 });
            Statuses.Add(new Status() { Name = "Pending", BackColor = 0xFFFFFF, ForeColor = 0x000000 });
            Statuses.Add(new Status() { Name = "Completed", BackColor = 0x91E397, ForeColor = 0x085E0E });
        }

        public void AddTransactions(IEnumerable<Transaction> list)
        {
            Transactions.AddRange(list);
        }

        public void AddTransaction(Transaction t)
        {
            Transactions.Add(t);
        }

        public List<LedgerTransation> LedgerTransactions
        {
            get
            {
                // Generate Recurring Transactions
                var trans = new List<Transaction>();
                foreach(var rt in RecurringTransactions)
                {
                    trans.AddRange(rt.GenerateToDate(null, DateTime.Today.AddDays(DaysToForecast)));
                }

                trans.AddRange(Transactions);
                var ot = trans.OrderBy(t => t.Date);

                var lts = new List<LedgerTransation>(ot.Count());
                
                decimal balance = 0;
                foreach (var t in ot)
                {
                    balance += t.Amount;
                    var lt = LedgerTransation.Create(t);
                    lt.Balance = balance;
                    lts.Add(lt);
                }

                return lts;
            }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}