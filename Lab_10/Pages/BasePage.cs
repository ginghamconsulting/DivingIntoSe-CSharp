using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab_10.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public void Visit(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public String Title()
        {
            return driver.Title;
        }
        public IWebElement Find(By locator){
            return driver.FindElement(locator);
        }

        public IWebElement Find(By locator, int timeout){
            WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(timeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return Find(locator);
        }

        public void Click(By locator){
            Find(locator).Click();
        }
        public void Click(By locator, int timeout){
            Find(locator, timeout).Click();
        }

        public void Type( String text, By locator){
            Find(locator).SendKeys(text);
        }
        public void Type(String text, By locator, int timeout)
        {
            Find(locator, timeout).SendKeys(text);
        }

        public Boolean Displayed(By locator){
            try{
                return Find(locator).Displayed;
            }
            catch(NoSuchElementException){
                return false;
            }
        }
        
        public Boolean Displayed(By locator, int timeout){
            try{
                WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            }
            catch(TimeoutException){
                return false;
            }
            return true;
        }

        private SelectElement Select(By locator)
        {
            return new SelectElement(Find(locator));
            
        }
        public void SelectOptionText(String text, By locator)
        {
            Select(locator).SelectByText(text);
        }
    }
}
