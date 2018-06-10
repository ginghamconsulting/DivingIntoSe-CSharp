using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_9.Pages
{
    public class ConfigurationPage : BasePage
    {
        private String PageTitle = "Entity Heirarchy";

        public ConfigurationPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == PageTitle);
        }
    }
}