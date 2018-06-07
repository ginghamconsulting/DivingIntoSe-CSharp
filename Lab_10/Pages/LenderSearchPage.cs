using System;
using System.Diagnostics;
using Lab_10.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class LenderSearchPage : BasePage
    {

        private By BaseLoanAmountField = By.Id("BaseLoanAmount");
        private By EstimatedValueField = By.Id("SalesAmount");
        private By BorrowerFICOField = By.Id("CustomLenderField1");
        private By DTIRatioField = By.Id("DTIRatio");
        private By CountySelect = By.Id("County");
        private By SubmitButton = By.Id("btnSubmit_search_bottom");

        
        
        public LenderSearchPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == "Product Search");
        }

        public LenderSearchPage SearchFor(LoanSearch Loan)
        {
            EnterLoanAmount(Loan.BaseLoanAmount).EnterEstimatedValue(Loan.EstimatedValue).EnterBorrowerFICO(Loan.BorrowerFICO)
                .EnterDTIRatio(Loan.DTIRatio);

            if (Loan.HasCounty == false)
            {
                Loan.SetCounty();
            }
            
            SelectCounty(Loan.County);

            
            return new LenderSearchPage(driver);

        }

        public LenderSearchResultsPage Search()
        {
            Click(SubmitButton);
            return new LenderSearchResultsPage(driver);
        }
        
        public LenderSearchPage EnterLoanAmount(int BaseLoanAmount)
        {
            Type(BaseLoanAmount.ToString(), BaseLoanAmountField);
            return this;
        }

        public LenderSearchPage EnterEstimatedValue(int EstimatedValue)
        {
            Type(EstimatedValue.ToString(),EstimatedValueField);
            return this;
        }

        public LenderSearchPage EnterBorrowerFICO(int BorrowerFICO)
        {
            Type(BorrowerFICO.ToString(), BorrowerFICOField);
            return this;
        }
        public LenderSearchPage EnterDTIRatio(int DTIRatio)
        {
            Type(DTIRatio.ToString(), DTIRatioField);
            return this;
        }

        public LenderSearchPage SelectCounty(LoanSearch.CountyOptions County)
        {
            SelectOptionText(County.ToString(), CountySelect);
            return this;
        }

    }
}