using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using CoinFrog.Models;

namespace CoinFrogTests.Models
{
    [TestClass]
    public class RecurringTransactionTests
    {
        [TestMethod]
        public void GenerateToDate_Should_Generate_Correct_Number_Of_Transactions_For_Daily()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2015-01-01");
            var end = DateTime.Parse("2015-01-28");
            var baseTrans = new Transaction() { Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" };

            var list = sut.GenerateToDate(start, 1, EveryType.Day, null, end, baseTrans);

            Assert.AreEqual(28, list.Count);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_Correct_Number_Of_Transactions_For_Every_Other_Day()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2015-01-01");
            var end = DateTime.Parse("2015-01-28");
            var baseTrans = new Transaction() { Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" };

            var list = sut.GenerateToDate(start, 2, EveryType.Day, null, end, baseTrans);

            Assert.AreEqual(14, list.Count);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_53_Transactions_For_Weekly_In_A_Year()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2014-01-01");
            var end = DateTime.Parse("2014-12-31");
            var baseTrans = new Transaction() { Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" };

            var list = sut.GenerateToDate(start, 1, EveryType.Week, new List<int>(){1}, end, baseTrans);

            Assert.AreEqual(53, list.Count);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_4_Transactions_For_Quarterly_In_A_Year()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2014-01-01");
            var end = DateTime.Parse("2014-12-31");

            var baseTrans = new Transaction() { Amount = 175, Description = "Water bill", AmountFinal = false, Status = "To Do" };

            var list = sut.GenerateToDate(start, 3, EveryType.Month, new List<int>() { 20 }, end, baseTrans);

            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_4_Transactions_On_The_Right_DayOfMonth_For_Quarterly_In_A_Year()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2014-01-01");
            var end = DateTime.Parse("2014-12-31");

            var baseTrans = new Transaction() { Amount = 175, Description = "Water bill", AmountFinal = false, Status = "To Do" };

            var list = sut.GenerateToDate(start, 3, EveryType.Month, new List<int>() { 20 }, end, baseTrans);

            Assert.AreEqual(20, list[0].Date.Day);
            Assert.AreEqual(20, list[3].Date.Day);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_24_Transactions_First_And_Fifteenth_of_each_month_Schedule()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2014-01-01");
            var end = DateTime.Parse("2014-12-31");

            var baseTrans = new Transaction() { Amount = 199.65m, Description = "gubment money", AmountFinal = true, Status = "To Do" };

            var list = sut.GenerateToDate(start, 1, EveryType.Month, new List<int>() { 1, 15 }, end, baseTrans);

            Assert.AreEqual(24, list.Count);
        }

        [TestMethod]
        public void GenerateToDate_Should_Generate_Transactions_On_Correct_Days_for_a_First_And_Fifteenth_of_each_month_Schedule()
        {
            var sut = new RecurringTransaction();

            var start = DateTime.Parse("2014-01-01");
            var end = DateTime.Parse("2014-12-31");

            var baseTrans = new Transaction() { Amount = 199.65m, Description = "gubment money", AmountFinal = true, Status = "To Do" };

            var list = sut.GenerateToDate(start, 1, EveryType.Month, new List<int>() { 1, 15 }, end, baseTrans);

            Assert.AreEqual(1, list[0].Date.Day);
            Assert.AreEqual(15, list[1].Date.Day);
            Assert.AreEqual(1, list[22].Date.Day);
            Assert.AreEqual(15, list[23].Date.Day);
        }
    }
}