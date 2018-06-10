using Lab_8.Helper;
using NUnit.Framework;

namespace Lab_8.Tests
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
            Loan loan = new Loan(100000, 200000, 650, 15, Loan.CountyOptions.Blount);
            Login.With("AndrewLO1", "Pselenium")
                .EnterOptimalLenderPage()
                .NewSearch()
                .SearchFor(loan)
                .Search()
                .ExpandLender(1)
                .LockRate(1).ValidateLoanAmount(loan);
        }
    }
}
