using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab_1.Pages
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        public IWebElement Find(By locator){
            return this.driver.FindElement(locator);
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
    }
}
