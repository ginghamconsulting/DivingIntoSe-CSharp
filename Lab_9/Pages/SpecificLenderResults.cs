using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Lab_9.Pages
{
    public class SpecificLenderResults : LenderSearchResultsPage
    {
        private String Id;
        private IWebElement Panel;
        private IList<IWebElement> ProductDetails;
        private string PanelXpath;

        public enum LockPeriod
        {
            Seven = 7, Fifthteen = 15, Thirty = 30, FortyFive = 45, Sixty = 60, SeventyFive = 75 
        }
        
        public SpecificLenderResults(IWebDriver driver, String Id) : base(driver)
        {
            this.Id = Id;
            this.PanelXpath =
                String.Format("//table[@id='ResultPanel_tblQualified']//tr[@id='{0}']/following-sibling::tr[1]", Id);
            this.Panel = Find(By.XPath(PanelXpath));
            GetProductDetails();
        }

        public LockPage LockRate(int RowNumber)
        {
            IWebElement ProductDetail = GetProductDetails()[RowNumber];
            ProductDetail.FindElement(By.XPath("//td[12]/a")).Click();
            return new LockPage(driver);
        }

        private IList<IWebElement> GetProductDetails()
        {
            return Panel.FindElements(By.XPath("//tr[@class='pricegrid']"));
        }

        public SpecificLenderResults SwitchLockPeriod(LockPeriod days)
        {
            IWebElement lockOptions = Panel.FindElement(By.XPath("//div[contains(@class,'DetailProdLabel')]"));
            lockOptions.FindElement(By.CssSelector("a[lock='" + (int) days + "']")).Click();
            return this;
        }
        
    }
}