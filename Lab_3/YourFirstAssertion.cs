using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_3
{
    [TestFixture]
    public class YourFirstAssertion
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
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.CssSelector("#login button[type='submit']")).Click();
            //TODO: Write Assertion
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}