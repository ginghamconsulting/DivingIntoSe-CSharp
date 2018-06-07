using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class OptimalLenderPage : BasePage
    {
        private String Title = "Secondary Queue";
        private By SearchButton = By.CssSelector("a[link_href='product_search.aspx']");

        public OptimalLenderPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == this.Title);
        }


        public LenderSearchPage NewSearch()
        {
            Click(SearchButton);
            return new LenderSearchPage(driver);
        }
    }
}