using System;

namespace BLL
{
    public class TaxOnLine
    {
        public double TaxationRate;
        private string _taxationType;
        public string? Comment { get; set; }
        
        public TaxOnLine(double taxationRate, string taxationType)
        {
            TaxationRate = taxationRate;
            _taxationType = taxationType;
        }
    }
}