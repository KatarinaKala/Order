using BLL.Order;

namespace BLL
{
    //Represents an event that, when applied to an OPEN Order, 
    //records a Payment requested, made, or accepted against the Order
    public class PaymentEvent : OrderEvent
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }
        public string InvoiceIdentifier { get; set; }
    }

    public class InvoiceEvent : PaymentEvent
    {
        public string DespatchIdentifier { get; set; }
    }
    
    public class MakePaymentEvent : PaymentEvent
    {
        
    }
    
    public class AcceptRefundEvent : PaymentEvent
    {
        
    }
    
    public class AcceptPaymentEvent : PaymentEvent
    {
        
    }
    
    public class MakeRefundEvent : PaymentEvent
    {
        
    }
    
}