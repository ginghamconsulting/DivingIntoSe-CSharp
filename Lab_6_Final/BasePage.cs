using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab_6_Final
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
                WebDriverWait wait = new WebDriverWait(this.driver, new TimeSpan(0,0,timeout));
                wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            }
            catch(TimeoutException){
                return false;
            }
            return true;
        }
    }
}