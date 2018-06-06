using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Project_1
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
        public void IE_Test()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com");
            driver.Quit();
        }
    }
}