namespace Order
{
    //Represents an event that, when applied to an Order, 
    //causes one or more Discounts to be recorded against the Order
    public class DiscountEvent : OrderEvent
    {
        public bool Add { get; set; }
    }
}