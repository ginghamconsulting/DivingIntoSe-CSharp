namespace Lab_9.Helper
{
    public class Loan
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
        public Loan(int BaseLoanAmount, int EstimatedValue, int BorrowerFICO, int DTIRatio, CountyOptions county)
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

        public Loan SetCounty(CountyOptions county)
        {
            this.HasCounty = true;
            this.County = county;
            return this;
        }

        public CountyOptions County { get; set; }

        public Loan SetCounty()
        {
            SetCounty(EnumHelper.RandomEnum<Loan.CountyOptions>());
            return this;
        }
    }
}