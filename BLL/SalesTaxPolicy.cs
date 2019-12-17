namespace BLL
{
    public class SalesTaxPolicy
    {
        public string _taxationType;
        private double _taxationRate;
        
        public SalesTaxPolicy(string taxationType, double taxationRate)
        {
            _taxationType = taxationType;
            _taxationRate = taxationRate;
        }
    }
}