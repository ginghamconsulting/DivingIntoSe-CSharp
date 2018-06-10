using System;
using Lab_8.Helper;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_8.Pages
{
    public class LenderSearchPage : BasePage
    {

        protected By BaseLoanAmountField = By.Id("BaseLoanAmount");
        protected By EstimatedValueField = By.Id("SalesAmount");
        protected By BorrowerFICOField = By.Id("CustomLenderField1");
        protected By DTIRatioField = By.Id("DTIRatio");
        protected By CountySelect = By.Id("County");
        protected By SubmitButton = By.Id("btnSubmit_search_bottom");
        private String PageTitle = "Product Search";

        
        /// <summary>
        /// Constructor for Lender Search Page
        ///
        /// The alternative is to make a BaseLoanFormPAge and then have this and the LockPage extend it with their details
        /// </summary>
        /// <param name="driver">Selenium WebDriver</param>
        /// <param name="child">if true do not run the assert message</param>
        public LenderSearchPage(IWebDriver driver, Boolean child = false) : base(driver)
        {
            if (child == false)
            {
                Assert.That(Title() == PageTitle);
            }
        }
       

        public LenderSearchPage SearchFor(Loan Loan)
        {
            EnterLoanAmount(Loan.BaseLoanAmount).EnterEstimatedValue(Loan.EstimatedValue).EnterBorrowerFICO(Loan.BorrowerFICO)
                .EnterDTIRatio(Loan.DTIRatio).SelectCounty(Loan.County);

            
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

        public LenderSearchPage SelectCounty(Loan.CountyOptions County)
        {
            SelectOptionText(County.ToString(), CountySelect);
            return this;
        }

    }
}