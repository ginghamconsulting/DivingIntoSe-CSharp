using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_4
{
    public class LoginTest
    {
        private IWebDriver driver;
        private LoginPage login;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            login = new LoginPage(driver);
        }

        [Test]
        public void SuccessfulLoginTest()
        {
            //TODO: Follow Lab 4 to refactor to use Page Objects
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.CssSelector("#login button[type='submit']")).Click();
            Assert.True(driver.FindElement(By.CssSelector(".flash.success")).Displayed);        
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}