using System;

namespace BLL.Discount
{
    public class Discount
    {
        public string Reason { get; set; }

        public virtual Price CalculateDiscountedPrice(Price price)
        {
            throw new NotImplementedException();
        }
    }

    public class MonetaryDiscount : Discount
    {
        public override Price CalculateDiscountedPrice(Price price)
        {
            throw new NotImplementedException();
        }
    }
    
    public class PercentageDiscount : Discount
    {
        public override Price CalculateDiscountedPrice(Price price)
        {
            throw new NotImplementedException();
        }
    }
}