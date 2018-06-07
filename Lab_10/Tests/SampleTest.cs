using System;
using Lab_10.Helper;
using Lab_10.Pages;
using NUnit.Framework;

namespace Lab_10.Tests
{
    public class SampleTest : BaseTest
    {
//        [Test]
//        public void SampleTest1()
//        {
//            driver.Navigate().GoToUrl("https://lazycoder.io");
//        }

        [Test]
        public void SearchTest()
        {
            var one = Login.With("AndrewLO1", "Pselenium");
            var two = one.EnterOptimalLenderPage();
            var three = two.NewSearch();
            var four = three.SearchFor(new LoanSearch(100000, 200000, 650, 15, LoanSearch.CountyOptions.Blount));
            var five = four.Search();
            var six = five.ExpandLender(1);
            var seven = six.LockRate(1);
        }
    }
}
