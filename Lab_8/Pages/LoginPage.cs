using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_8.Pages
{
    public class LoginPage : BasePage
    {
        private String Url = "https://qa.optimalblue.com/optimalblue/index2.aspx";


        private By LoginForm = By.Id("Form1");
        private By UsernameField = By.Id("UserName");
        private By PasswordField = By.Id("UserPassword");
        private By SubmitButton = By.CssSelector("#Form1 input[type='submit'");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            Visit(Url);
            Assert.That(Displayed(LoginForm), "Login Form is not present");
        }

        public DashboardPage With(String username, String password)
        {
            Type(username, UsernameField);
            Type(password, PasswordField);
            Click(SubmitButton);
            return new DashboardPage(driver);
        }
    }
}