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

        public SortedList<DateTime, Transaction> Transactions { get; private set; }

        private Random rnd = new Random(DateTime.Now.Millisecond * 13);

        public Ledger()
        {
            Transactions = new SortedList<DateTime, Transaction>();
        }

        public void AddTransactions(IEnumerable<Transaction> list)
        {
            foreach (var t in list)
            {
                AddTransaction(t);
            }
        }

        public void AddTransaction(Transaction t)
        {
            // Hack: add a random # of ticks so that transactions on the same date are not considered duplicates
            // Should really use a sorted collection that can handle dupes but I didnt realize SortedList didn't allow dupes
            // and didnt't feel like changing it after the fact.
            t.Date = t.Date.AddTicks((UInt32)rnd.Next());
            Transactions.Add(t.Date, t);
        }

        public List<LedgerTransation> LedgerTransactions
        {
            get
            {
                var ot = Transactions.Select(t => t.Value); // .OrderBy(t => t.Date)
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