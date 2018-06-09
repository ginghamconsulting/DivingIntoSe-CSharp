using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab_5_Final
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
            login.With("tomsmith", "SuperSecretPassword!");
            Assert.True(login.SuccessMessagePresent(), "Success message not present");        
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}