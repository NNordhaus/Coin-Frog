using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using CoinFrog.Models;

namespace CoinFrogTests.Models
{
    public class RecurringTransactionTests
    {
        [TestClass]
        public class GenerateToDate
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Should_reject_a_StartDate_after_EndDate()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction()
                    {
                        Date = DateTime.Parse("2015-01-01"),
                    },
                    Num = 1,
                    Every = PeriodType.Days
                };

                sut.GenerateToDate(null, DateTime.Parse("2014-01-01"));
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Should_reject_a_non_positive_num()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction()
                    {
                        Date = DateTime.Parse("2014-01-01"),
                    },
                    Num = 0,
                    Every = PeriodType.Days
                };

                sut.GenerateToDate(null, DateTime.Parse("2015-01-01"));
            }

            [TestMethod]
            public void Should_Generate_Correct_Number_Of_Transactions_For_Daily()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2015-01-01"), Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" },
                    Every = PeriodType.Days,
                    Num = 1
                };

                var end = DateTime.Parse("2015-01-28");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(28, list.Count);
            }

            [TestMethod]
            public void Should_Generate_Correct_Number_Of_Transactions_For_Every_Other_Day()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2015-01-01"), Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" },
                    Num = 2,
                    Every = PeriodType.Days
                };

                var end = DateTime.Parse("2015-01-28");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(14, list.Count);
            }

            [TestMethod]
            public void Should_Generate_53_Transactions_For_Weekly_In_A_Year()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2014-01-01"), Amount = 100, Description = "Paycheck", AmountFinal = true, Status = "Projected" },
                    Num = 1,
                    Every = PeriodType.Weeks,
                    On = new List<int>() { 1 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(53, list.Count);
            }

            [TestMethod]
            public void Should_Generate_4_Transactions_For_Quarterly_In_A_Year()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2014-01-01"), Amount = -175, Description = "Water bill", AmountFinal = false, Status = "To Do" },
                    Num = 3,
                    Every = PeriodType.Months,
                    On = new List<int>() { 20 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(4, list.Count);
            }

            [TestMethod]
            public void Should_Generate_4_Transactions_On_The_Right_DayOfMonth_For_Quarterly_In_A_Year()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2014-01-01"), Amount = -175, Description = "Water bill", AmountFinal = false, Status = "To Do" },
                    Num = 3,
                    Every = PeriodType.Months,
                    On = new List<int>() { 20 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(20, list[0].Date.Day);
                Assert.AreEqual(20, list[3].Date.Day);
            }

            [TestMethod]
            public void Should_Generate_24_Transactions_First_And_Fifteenth_of_each_month_Schedule()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2014-01-01"), Amount = 199.65m, Description = "gubment money", AmountFinal = true, Status = "To Do" },
                    Num = 1,
                    Every = PeriodType.Months,
                    On = new List<int>() { 1, 15 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(24, list.Count);
            }

            [TestMethod]
            public void Should_Generate_Transactions_On_Correct_Days_for_a_First_And_Fifteenth_of_each_month_Schedule()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2014-01-01"), Amount = 199.65m, Description = "gubment money", AmountFinal = true, Status = "To Do" },
                    Num = 1,
                    Every = PeriodType.Months,
                    On = new List<int>() { 1, 15 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(1, list[0].Date.Day);
                Assert.AreEqual(15, list[1].Date.Day);
                Assert.AreEqual(1, list[22].Date.Day);
                Assert.AreEqual(15, list[23].Date.Day);
            }

            [TestMethod]
            public void Should_Generate_5_Transactions_for_1_day_per_year_over_5_years()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2010-01-01"), Amount = 199.65m, Description = "Tax Refund", AmountFinal = true, Status = "Projected" },
                    Num = 1,
                    Every = PeriodType.Years,
                    On = new List<int>() { 15 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(5, list.Count);
            }

            [TestMethod]
            public void Should_Generate_10_Transactions_for_twice_a_year_over_5_years()
            {
                var sut = new RecurringTransaction()
                {
                    BaseTransaction = new Transaction() { Date = DateTime.Parse("2010-01-01"), Amount = -1200, Description = "Property Tax", AmountFinal = false, Status = "Auto Debit" },
                    Num = 1,
                    Every = PeriodType.Years,
                    On = new List<int>() { 173, 356 }
                };

                var end = DateTime.Parse("2014-12-31");

                var list = sut.GenerateToDate(null, end);

                Assert.AreEqual(10, list.Count);
            }

            [TestMethod]
            public void Should_Not_Generate_Prior_to_StarDate()
            {
                Assert.Inconclusive();
            }

            [TestMethod]
            public void Should_Not_Generate_Past_EndDate()
            {
                Assert.Inconclusive();
            }
        }

        [TestClass]
        public class Summary
        {
            [TestMethod]
            public void Should_correctly_state_Every_day()
            {
                var sut = new RecurringTransaction();
                sut.Every = PeriodType.Days;
                sut.Num = 1;

                var actual = sut.RecurringSummary;
                Assert.AreEqual("Every Day", actual);
            }

            [TestMethod]
            public void Should_correctly_state_Every_Thursday()
            {
                var sut = new RecurringTransaction();
                sut.Every = PeriodType.Weeks;
                sut.Num = 1;
                sut.On = new List<int>() { 5 };

                var actual = sut.RecurringSummary;
                Assert.AreEqual("Every Thursday", actual);
            }

            [TestMethod]
            public void Should_correctly_state_1st_of_the_Month()
            {

            }

            [TestMethod]
            public void Should_correctly_state_Every_3_Months()
            {

            }
            
            [TestMethod]
            public void Should_correctly_state_Every_N_days()
            {

            }
        }
    }
}