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
        public List<Status> Statuses { get; set; }
        public int DaysToForecast { get; set; }
        public Ledger()
        {
            Transactions = new List<Transaction>();
            Statuses = new List<Status>();
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
                var ot = Transactions.OrderBy(t => t.Date);
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