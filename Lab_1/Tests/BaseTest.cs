using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_1.Tests
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver driver;

        public BaseTest()
        {}

        [SetUp]
        public void Setup(){
            this.driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown(){
            driver.Quit();
        }
    }
}
