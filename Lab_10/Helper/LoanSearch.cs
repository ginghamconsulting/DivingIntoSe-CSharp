using System;
using System.Diagnostics.PerformanceData;
using static Lab_10.Helper.EnumHelper;

namespace Lab_10.Helper
{
    public class LoanSearch
    {

        public enum CountyOptions 
        {
            Autauga, Baldwin, Barbour, Bibb, Blount, Bullock, Butler, Calhoun, Chambers, Cherokee,
            Chilton, Choctaw, Clarke, Clay, Cleburne, Coffee, Colbert, Conecuh, Coosa, Covington,
            Crenshaw, Cullman, Dale, Dallas, DeKalb, Elmore, Escambia, Etowah, Fayette, Franklin,
            Geneva, Greene, Hale, Henry, Houston, Jackson, Jefferson, Lamar, Lauderdale, Lawrence,
            Lee, Limestone, Lowndes, Macon, Madison, Marengo, Marion, Marshall, Mobile, Monroe,
            Montgomery, Morgan, Perry, Pickens, Pike, Randolph, Russell, Shelby, StClair, Sumter,
            Talladega, Tallapoosa, Tuscaloosa, Walker, Washington, Wilcox, Winston
        };
        public LoanSearch(int BaseLoanAmount, int EstimatedValue, int BorrowerFICO, int DTIRatio, CountyOptions county)
        {
            this.BaseLoanAmount = BaseLoanAmount;
            this.EstimatedValue = EstimatedValue;
            this.BorrowerFICO = BorrowerFICO;
            this.DTIRatio = DTIRatio;
            this.HasCounty = false;
            SetCounty(county);
        }

        public bool HasCounty { get; set; }

        public int DTIRatio { get; set; }

        public int BorrowerFICO { get; set; }

        public int EstimatedValue { get; set; }

        public int BaseLoanAmount { get; set; }

        public LoanSearch SetCounty(CountyOptions county)
        {
            this.County = county;
            return this;
        }

        public LoanSearch SetCounty()
        {
            SetCounty(RandomEnum<LoanSearch.CountyOptions>());
            return this;
        }

        public CountyOptions County
        {
            get { return this.County;}
            set
            {
                this.HasCounty = true;
                this.County = value;
            }
        }
    }
}