using System;
using System.Collections.Generic;
using BLL.Order;

namespace BLL
{
    public class ChargeLine
    {
        //Lisatasu (nt kiire kohaletoimetamise eest)
        private int _amount;
        private string? Description { get; set; }
        private string? Comment { get; set; }
        private List<TaxOnLine> _taxOnLines = new List<TaxOnLine>();
        public OrderLineIdentifier OrderLineIdentifier { get;}

        public ChargeLine(int amount)
        {
            _amount = amount;
        }

        public void AddTax(TaxOnLine tax)
        {
            _taxOnLines.Add(tax);
        }

        public List<TaxOnLine> GetTaxes()
        {
            return _taxOnLines;
        }

        public void RemoveTax(TaxOnLine tax)
        {
            _taxOnLines.Remove(tax);
        }
    }
}