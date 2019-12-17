using System.Collections.Generic;
using BLL.Order;

namespace BLL
{
    public class ChargeLine
    {
        //Lisatasu (nt kiire kohaletoimetamise eest)
        public int Amount { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public List<TaxOnLine> TaxOnLines { get; set; }
        
        public OrderLineIdentifier OrderLineIdentifier { get; set; }

        public void AddTax(TaxOnLine tax)
        {
            TaxOnLines.Add(tax);
        }

        public List<TaxOnLine> GetTaxes()
        {
            return TaxOnLines;
        }

        public void RemoveTax(TaxOnLine tax)
        {
            TaxOnLines.Remove(tax);
        }
    }
}