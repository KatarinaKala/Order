namespace BLL
{
    public class SalesTaxPolicy
    {
        private string _taxationType;
        private double _taxationRate;
        
        public SalesTaxPolicy(string taxationType, double taxationRate)
        {
            _taxationType = taxationType;
            _taxationRate = taxationRate;
        }
    }
}