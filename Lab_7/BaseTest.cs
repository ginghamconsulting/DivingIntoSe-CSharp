using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Lab_7
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class BaseTest
    {
        public BaseTest(String browser)
        {
            this.browser = browser;
        }
        private IWebDriver driver;
        private string browser;

       // [SetUp]
        public void setUp() {
            if(browser.ToLower().Equals("chrome"))
                this.driver = new ChromeDriver();
            else
            {
                this.driver = new InternetExplorerDriver();
            }
        }
        
        [TearDown]        
        public void TearDown() {
            this.driver.Quit();
        }
    }
}