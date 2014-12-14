using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using CoinFrog.Models;

namespace CoinFrogTests.Models
{
    [TestClass]
    public class TransactionTests
    {
        [TestMethod]
        public void Clone_Should_Correctly_Clone_All_Properties()
        {
            var sut = new Transaction()
            {
                Amount = 123.45m,
                AmountFinal = true,
                Date = DateTime.Parse("2015-01-01"),
                DateFinal = true,
                Description = "deskripshun",
                DescriptionBackColor = Color.LightGray.ToArgb(),
                RecurrenceName = "paycheck",
                Status = "Complete"
            };

            var actual = sut.Clone();

            Assert.AreEqual(sut.Amount, actual.Amount);
            Assert.AreEqual(sut.AmountFinal, actual.AmountFinal);
            Assert.AreEqual(sut.Date, actual.Date);
            Assert.AreEqual(sut.DateFinal, actual.DateFinal);
            Assert.AreEqual(sut.Description, actual.Description);
            Assert.AreEqual(sut.DescriptionBackColor, actual.DescriptionBackColor);
            Assert.AreEqual(sut.RecurrenceName, actual.RecurrenceName);
            Assert.AreEqual(sut.Status, actual.Status);
        }
    }

    [TestClass]
    public class LedgerTransactionTests
    {
        public void Create_Should_Copy_All_Properties_from_Transaction()
        {
            var trans = new Transaction()
            {
                Amount = 123.45m,
                AmountFinal = true,
                Date = new DateTime(2015, 1, 1),
                DateFinal = true,
                Description = "desc",
                DescriptionBackColor = 500,
                RecurrenceName = "r",
                Status = "s"
            };

            var sut = LedgerTransation.Create(trans);

            Assert.AreEqual(trans.Amount, sut.Amount);
            Assert.AreEqual(trans.AmountFinal, sut.AmountFinal);
            Assert.AreEqual(trans.Date, sut.Date);
            Assert.AreEqual(trans.DateFinal, sut.DateFinal);
            Assert.AreEqual(trans.Description, sut.Description);
            Assert.AreEqual(trans.DescriptionBackColor, sut.DescriptionBackColor);
            Assert.AreEqual(trans.RecurrenceName, sut.RecurrenceName);
            Assert.AreEqual(trans.Status, sut.Status);
            Assert.AreEqual(0f, sut.Balance);
        }
    }
}