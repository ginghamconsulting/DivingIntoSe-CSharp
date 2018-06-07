using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class ConfigurationPage : BasePage
    {
        private String Title = "Entity Heirarchy";

        public ConfigurationPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == Title);
        }
    }
}