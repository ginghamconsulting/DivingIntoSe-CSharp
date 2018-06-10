using System;
using Lab_9.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_9.Pages
{
    public class LockPage : LoanBasePage
    {

        private String PageTitle = "Save Loan";
        private By WarningMessage = By.Id("ctl00_CPH_ChangeWarning");
        
        public LockPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Find(WarningMessage).Text ==
                        "Changes made on the Lock Form will not be evaluated by the product and pricing engine.");
        }

        public LockPage ValidateLoanAmount(Loan Loan)
        {
            Console.WriteLine("Page Loan Amount: " + Find(BaseLoanAmountField).GetAttribute("value"));
            Console.WriteLine("Loan Amount:      " + Loan.BaseLoanAmount.ToString());
            Assert.That(Find(BaseLoanAmountField).GetAttribute("value") == Loan.BaseLoanAmount.ToString());
            return this;
        }
    }
}