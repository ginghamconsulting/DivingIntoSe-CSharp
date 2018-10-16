using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace Lab_1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Chrome_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            driver.Quit();
        }
        [Test]
        public void FF_Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            driver.Quit();
        }
    }
}