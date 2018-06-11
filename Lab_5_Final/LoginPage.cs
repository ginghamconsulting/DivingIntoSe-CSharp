using System;
using NUnit.Framework;
using OpenQA.Selenium;
namespace Lab_5_Final
{
    public class LoginPage : BasePage
    {
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
            Type(password,passwordLocator);
            Click(submitButton);
        }

        public Boolean SuccessMessagePresent()
        {
            return Displayed(successMessageLocator);
        }

        public Boolean FailureMessagePresent()
        {
            return Displayed(failureMessageLocator);
        }
    }
}
