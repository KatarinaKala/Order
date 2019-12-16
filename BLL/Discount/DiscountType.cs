using System;

namespace BLL.Discount
{
    public class DiscountType
    {

        public Decimal Discount { get; set; }
        public Discount GetDiscount(RuleContext context)
        {
            throw new NotImplementedException();
        }
    }
}