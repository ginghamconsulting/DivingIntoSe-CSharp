using System;
using OpenQA.Selenium;

namespace Lab_6
{
    public class BasePage
    {
        private IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Visit(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement Find(By locator){
            return driver.FindElement(locator);
        }

        public void Click(By locator){
            Find(locator).Click();
        }

        public void Type( String text, By locator){
            Find(locator).SendKeys(text);
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
                return Find(locator).Displayed;
            }
            catch(NoSuchElementException){
                return false;
            }
        }
    }
}