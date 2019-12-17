using System;

namespace BLL
{
    public class TaxOnLine
    {
        private double _taxationRate;
        private string _taxationType;
        public string? Comment { get; set; }
        
        public TaxOnLine(double taxationRate, string taxationType)
        {
            _taxationRate = taxationRate;
            _taxationType = taxationType;
        }
    }
}