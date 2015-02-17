using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CoinFrog.Models
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public bool AmountForecasted { get; set; }
        public bool AmountFinal { get; set; }
        public string Description { get; set; }
        public int DescriptionForeColor { get; set; }
        public int DescriptionBackColor { get; set; }
        public DateTime Date { get; set; }
        public bool DateFinal { get; set; }
        public string Status { get; set; }
        public string RecurrenceName { get; set; }

        public Transaction()
        {
            // Default colors
            DescriptionBackColor = Color.White.ToArgb();
            DescriptionForeColor = Color.Black.ToArgb();
        }

        public Transaction Clone()
        {
            return new Transaction()
            {
                Amount = Amount,
                Description = Description,
                DescriptionForeColor = DescriptionForeColor,
                DescriptionBackColor = DescriptionBackColor,
                Date = Date,
                AmountFinal = AmountFinal,
                DateFinal = DateFinal,
                Status = Status,
                RecurrenceName = RecurrenceName
            };
        }
    }

    public class LedgerTransation : Transaction
    {
        public decimal Balance { get; set; }

        public static LedgerTransation Create(Transaction t)
        {
            return new LedgerTransation()
            {
                Amount = t.Amount,
                AmountFinal = t.AmountFinal,
                Balance = 0m,
                Date = t.Date,
                DateFinal = t.DateFinal,
                Description = t.Description,
                DescriptionForeColor = t.DescriptionForeColor,
                DescriptionBackColor = t.DescriptionBackColor,
                RecurrenceName = t.RecurrenceName,
                Status = t.Status
            };
        }
    }
}