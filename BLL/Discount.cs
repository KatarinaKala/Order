namespace Order
{
    public class Discount
    {
        public string Reason { get; set; }

        public virtual Price CalculateDiscountedPrice(Price price)
        {
            
        }
    }

    public class MonetaryDiscount : Discount
    {
        public override Price CalculateDiscountedPrice(Price price)
        {
            
        }
    }
    
    public class PercentageDiscount : Discount
    {
        public override Price CalculateDiscountedPrice(Price price)
        {
            
        }
    }
}