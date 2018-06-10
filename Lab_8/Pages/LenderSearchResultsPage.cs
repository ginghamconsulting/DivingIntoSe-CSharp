using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_8.Pages
{
    public class LenderSearchResultsPage : BasePage
    {
        private By SearchResultsTable = By.Id("ResultPanel_tblQualified");

        private By EligibleProducts =
            By.XPath("//table[@id='ResultPanel_tblQualified']//tr[contains(@id,'ResultPanel_ProductRow_')]");

        public LenderSearchResultsPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == "Product Search Results");
        }

        private List<String> GetResultHeaders()
        {
            IList<IWebElement> headerElements = Find(SearchResultsTable).FindElements(By.CssSelector("th"));
            List<String> headers = new List<String>();
            foreach (IWebElement element in headerElements)
            {
                headers.Add(element.Text);
            }

            return headers;
        }

        private IList<IWebElement> GetResults()
        {
            IList<IWebElement> results = Finds(EligibleProducts);
            return results;
        }

        public SpecificLenderResults ExpandLender(int ListOrder)
        {
            IList<IWebElement> results = GetResults();
            String id = results[ListOrder].GetAttribute("id");
            results[ListOrder].FindElement(By.CssSelector("td.productcell.text a")).Click();
            return new SpecificLenderResults(driver, id);
        }
    }
}