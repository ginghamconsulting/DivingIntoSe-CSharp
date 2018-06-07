using System;
using NUnit.Framework;

namespace Lab_10.Tests
{
    public class SampleTest : BaseTest
    {
        [Test]
        public void SampleTest1()
        {
            driver.Navigate().GoToUrl("https://lazycoder.io");
        }
    }
}
