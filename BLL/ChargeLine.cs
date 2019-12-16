using System.Collections.Generic;

namespace Order
{
    public class ChargeLine
    {
        public Money Amount { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        public OrderLineIdentifier OrderLineIdentifier { get; set; }

        public void AddTax(TaxOnLine tax)
        {
            
        }

        public List<TaxOnLine> GetTaxes()
        {
            
        }

        public void RemoveTax(TaxOnLine tax)
        {
            
        }
    }
}