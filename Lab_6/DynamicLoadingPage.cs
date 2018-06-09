using System;
using OpenQA.Selenium;

namespace Lab_6
{
    public class DynamicLoadingPage : BasePage
    {
        By startButton = By.CssSelector("#start button");
        By finishText = By.Id("finish");

        public DynamicLoadingPage(IWebDriver driver) : base(driver){
        }

        public void LoadExample(String exampleNumber) {
            Visit("http://the-internet.herokuapp.com/dynamic_loading/" + exampleNumber);
            Click(startButton);
        }

        public Boolean FinishTextPresent() {
            return Displayed(finishText, 10);
        }
    }
}