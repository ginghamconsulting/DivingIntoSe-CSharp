using System;
using NUnit.Framework;
using OpenQA.Selenium;
namespace Lab_5
{
    public class LoginPage
    {
        //TODO: Follow Lab 5 Directions


        private By loginFormLocator = By.Id("login");
        private By usernameLocator = By.Id("username");
        private By passwordLocator = By.Id("password");
        private By submitButton = By.CssSelector("button");
        private By successMessageLocator = By.CssSelector(".flash.success");
        private By failureMessageLocator = By.CssSelector(".flash.error");
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Url = "http://the-internet.herokuapp.com/login";
            Assert.True(driver.FindElement(loginFormLocator).Displayed, "The login form is not present");
        }

        public void With(String username, String password)
        {
            driver.FindElement(usernameLocator).SendKeys(username);
            driver.FindElement(passwordLocator).SendKeys(password);
            driver.FindElement(submitButton).Click();
        }

        public Boolean SuccessMessagePresent()
        {
            return driver.FindElement(successMessageLocator).Displayed;
        }

        public Boolean FailureMessagePresent()
        {
            return driver.FindElement(failureMessageLocator).Displayed;
        }
    }
}
