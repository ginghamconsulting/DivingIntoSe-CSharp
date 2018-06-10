using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Protractor;

namespace Lab_10.Pages
{
    public class ProductPreferencesAndFiltersPage : BasePage
    {
        
        public enum AmortizationTypes
        {
            Fixed, ARM, Ballon
        }
        private String Title = "";
        private By BlockingModal = By.ClassName("overlay-content");
        private By ProductNameField = By.Id("product-set-name");
        private By SaveAndContinueButton = By.CssSelector("button[_ngcontent-c1]");
        private NgWebDriver ng;
        
        public ProductPreferencesAndFiltersPage(IWebDriver driver) : base(driver)
        {   
            
            // Uncomment to use Selenium to wait for the modal to disapper
            Displayed(BlockingModal, 10);
            WaitForElementToDisapper(BlockingModal, 10);
          
            
            // This is using the NgWebDriver that waits for Angular to load before preceeding
            ng = new NgWebDriver(driver);
            
            
            // If using NgWebDriver on a page without Angular it can be disabled with this line

            // ng.IgnoreSynchronization = true;
        }

        public ProductPreferencesAndFiltersPage NewProduct(String name)
        {
            // Generic Selenium 
            //  Type(name, ProductNameField);
            
            // Using plain locators with NgWebDriver
            ng.FindElement(ProductNameField).SendKeys(name);
            return this;
        }

        public ProductPreferencesAndFiltersPage SaveAndContinue()
        {
            Click(SaveAndContinueButton);
            return new ProductPreferencesAndFiltersPage(driver);
        }

        public ProductPreferencesAndFiltersPage SelectAmortizationTypes(List<AmortizationTypes> amortizations)
        {
            foreach (AmortizationTypes option in amortizations)
            {
                Click(By.XPath(String.Format("//label[text()='{0}']", option.ToString())));
            }

            return this;
        }
    }
}