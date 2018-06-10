using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Lab_8.Pages
{
    public class OptimalLenderPage : BasePage
    {
        private String PageTitle = "Secondary Queue";
        private By SearchButton = By.CssSelector("a[link_href='product_search.aspx']");

        public OptimalLenderPage(IWebDriver driver) : base(driver)
        {
            Assert.That(Title() == this.PageTitle);
        }


        public LenderSearchPage NewSearch()
        {
            Click(SearchButton);
            return new LenderSearchPage(driver);
        }
    }
}