using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab_10.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
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

        public IList<IWebElement> Finds(By locator)
        {
            return driver.FindElements(locator);
        } 

        public IWebElement Find(By locator, int timeout){
            WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(timeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return Find(locator);
        }

        public void Click(By locator){
            Find(locator).Click();
        }

        public void Click(IWebElement element)
        {
            element.Click();
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
                WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(0,0,timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            }
            catch(WebDriverTimeoutException){
                return false;
            }
            return true;
        }

        
        public Boolean WaitForElementToDisapper(By locator, int timeout){
            try{
                WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(0,0,timeout));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
            }
            catch(WebDriverTimeoutException){
                return false;
            }
            return true;
        }


        public Boolean WaitForElements(By locator, int timeout)
        {
            try{
                WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(0,0,timeout));
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
            }
            catch(WebDriverTimeoutException){
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
