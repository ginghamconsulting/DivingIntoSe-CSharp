using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class LenderSearchResultsPage : BasePage
    {
        private By SearchResultsTable = By.Id("ResultPanel_tblQualified");
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
    }
}