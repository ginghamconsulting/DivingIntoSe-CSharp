using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Lab_8
{
    public class DynamicLoadingTest 
    {
        private IWebDriver driver;
        private DynamicLoadingPage dynamicLoading;

        [SetUp]
        public void setUp() {
            driver = new ChromeDriver();
            dynamicLoading = new DynamicLoadingPage(driver);
        }

        [Test]
        public void HiddenElementLoads() {
            dynamicLoading.LoadExample("1");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't display after loading");
        }

        [Test]
        public void ElementAppears() {
            dynamicLoading.LoadExample("2");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't render after loading");
        }

        [TearDown]        
        public void TearDown() {
            driver.Quit();
        }
    }
}