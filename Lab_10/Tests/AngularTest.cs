using System.Collections.Generic;
using Lab_10.Pages;
using NUnit.Framework;

namespace Lab_10.Tests
{
    public class AngularTest : BaseTest
    {
        [Test]
        public void AngularTest1()
        {
            Login.With("AndrewLO1", "Pselenium").
                EnterConfiguration().
                SelectAvailableEntity("Bank2 - ").
                ManageProducts().
                CreateNewProduct().
                NewProduct("Sample").
                SaveAndContinue().
                SelectAmortizationTypes(
                    new List<ProductPreferencesAndFiltersPage.AmortizationTypes>()
                    {
                        ProductPreferencesAndFiltersPage.AmortizationTypes.ARM
                    }).
                SaveAndContinue();
        }
    }
}