using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;

namespace Lab_8
{
    public class Class1
    {
        private IWebDriver _driver;
        [Test]
        public void ShouldGreetUsingBinding()
        {
            // Instanciate a classic Selenium's WebDriver
            _driver = new ChromeDriver();
            // Configure timeouts (important since Protractor uses asynchronous client side scripts)
            _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            NgWebDriver driver = new NgWebDriver(_driver);
            driver.IgnoreSynchronization = false;
           
            _driver.Url = "http://www.angularjs.org";
            _driver.FindElement(NgBy.Model("yourName")).SendKeys("Julie");
            Assert.AreEqual("Hello Julie!", _driver.FindElement(NgBy.Binding("yourName")).Text);
            driver.Quit();
        }
    }
}