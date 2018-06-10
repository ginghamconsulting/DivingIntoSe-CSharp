using System;
using NUnit.Framework;

namespace Lab_7
{
    [TestFixture("Chrome")]
    [TestFixture("Firefox")]
    [Parallelizable(ParallelScope.All)]
    public class DynamicLoadingTest : BaseTest
    {
        private DynamicLoadingPage dynamicLoading;

        public DynamicLoadingTest(String browser) : base(browser)
        {
//            setUp();
//            dynamicLoading = new DynamicLoadingPage(driver);

        }
        
        [Test]
        public void HiddenElementLoads()
        {
            setUp();
            DynamicLoadingPage dynamicLoading = new DynamicLoadingPage(driver);
            dynamicLoading.LoadExample("1");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't display after loading");
        }

        [Test]
        public void ElementAppears() {
            setUp();
            DynamicLoadingPage dynamicLoading = new DynamicLoadingPage(driver);

            dynamicLoading.LoadExample("2");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't render after loading");
        }
    }
}