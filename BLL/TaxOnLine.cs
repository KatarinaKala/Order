namespace Order
{
    public class TaxOnLine
    {
        public double TaxationRate { get; set; } //Real andmetüüp- siin üllis protsent
        public string TaxationType { get; set; }
        public string Comment { get; set; }

        public Money CalculateTax(Money amount)
        {
            
        }
    }
}