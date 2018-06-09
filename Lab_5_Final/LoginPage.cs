using System;
using NUnit.Framework;
using OpenQA.Selenium;
namespace Lab_5_Final
{
    public class LoginPage : BasePage
    {
        //TODO: Follow Lab 5 Directions


        private By loginFormLocator = By.Id("login");
        private By usernameLocator = By.Id("username");
        private By passwordLocator = By.Id("password");
        private By submitButton = By.CssSelector("button");
        private By successMessageLocator = By.CssSelector(".flash.success");
        private By failureMessageLocator = By.CssSelector(".flash.error");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            driver.Url = "http://the-internet.herokuapp.com/login";
            Assert.True(Displayed(loginFormLocator), "The login form is not present");
        }

        public void With(String username, String password)
        {
            Type(username, usernameLocator);
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
