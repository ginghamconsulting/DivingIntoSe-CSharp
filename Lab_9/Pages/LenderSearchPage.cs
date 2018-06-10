using System;
using Lab_9.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_9.Pages
{
    public class LenderSearchPage : LoanBasePage
    {

        private String PageTitle = "Product Search";

        
        public LenderSearchPage(IWebDriver driver, Boolean child = false) : base(driver)
        {
            if (child == false)
            {
                Assert.That(Title() == PageTitle);
            }
        }
    }
}