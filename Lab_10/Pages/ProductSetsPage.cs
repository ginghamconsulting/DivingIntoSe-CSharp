using System;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class ProductSetsPage : BasePage
    {
        private String Title = "Product Sets";
        private By AddNewProductButton = By.ClassName("TableStyleLink");

        public ProductSetsPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductPreferencesAndFiltersPage CreateNewProduct()
        {
            Click(AddNewProductButton);
            return new ProductPreferencesAndFiltersPage(driver);
        }
    }
}