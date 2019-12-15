namespace Order
{
//OrderStatus is determined by the Order, according to what LifecycleEvents the Order has received
    public class LifecycleEvent : OrderEvent
    {
        
    }

    public class OpenEvent : LifecycleEvent
    {
        //represents an event sent to an Order that changes its OrderStatus to OPEN
    }
    
    public class CloseEvent : LifecycleEvent
    {
        //represents an event sent to an Order that changes its OrderStatus to CLOSED
    }
    
    public class CancelEvent : LifecycleEvent
    {
        //represents an event sent to an Order that changes its OrderStatus to CANCELLED
        public string Reason { get; set; }
    }
}