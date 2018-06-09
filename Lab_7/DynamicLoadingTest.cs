using NUnit.Framework;

namespace Lab_7
{
    [Parallelizable(ParallelScope.All)]
    public class DynamicLoadingTest : BaseTest
    {
        //private DynamicLoadingPage dynamicLoading;

        public DynamicLoadingTest()
        {
            //dynamicLoading = new DynamicLoadingPage(driver);

        }
        
        [Test]
        public void HiddenElementLoads()
        {
            DynamicLoadingPage dynamicLoading = new DynamicLoadingPage(driver);
            dynamicLoading.LoadExample("1");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't display after loading");
        }

        [Test]
        public void ElementAppears() {
            DynamicLoadingPage dynamicLoading = new DynamicLoadingPage(driver);

            dynamicLoading.LoadExample("2");
            Assert.True(dynamicLoading.FinishTextPresent(), "finish text didn't render after loading");
        }
    }
}