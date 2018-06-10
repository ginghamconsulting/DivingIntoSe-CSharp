using System;
using System.Collections.Generic;
using System.Net.Configuration;
using OpenQA.Selenium;

namespace Lab_10.Pages
{
    public class ConfigurationPage : BasePage
    {
        private By AvailableEntities = By.ClassName(".HierarchyLinkInherited");
        private By ManageProductsLink = By.CssSelector("a[mytarget='ProductSets.aspx']");
        

        public ConfigurationPage(IWebDriver driver) : base(driver)
        {
            WaitForElements(AvailableEntities, 10);
        }

        public ConfigurationPage SelectAvailableEntity()
        {
            IList<IWebElement> entities = Finds(AvailableEntities);
            Random rnd = new Random();
            
            Click(entities[rnd.Next(0, entities.Count-1)]);
            
            return new ConfigurationPage(driver);
        }

        public ConfigurationPage SelectAvailableEntity(String name)
        {
            IList<IWebElement> entities = Finds(AvailableEntities);

            Click(By.XPath(String.Format("//a[@class='HierarchyLinkInherited'][text()='{0}']", name)), 10);
            
            return new ConfigurationPage(driver);
        }

        public ProductSetsPage ManageProducts()
        {
            Click(ManageProductsLink, 10);
            return new ProductSetsPage(driver);
        }
    }
}