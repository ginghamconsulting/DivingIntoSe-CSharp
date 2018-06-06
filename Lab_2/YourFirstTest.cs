using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_2
{
    [TestFixture]
    public class YourFirstTest
    {
        private IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void LoginTest()
        {
            ///TODO: Write Selenium Commands for Login Test
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}