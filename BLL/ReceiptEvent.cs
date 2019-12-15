using System;
using System.Collections.Generic;

namespace Order
{
    //Represents an event that, when applied to an OPEN PurchaseOrder,
    //records goods or services received from a vendor.
    public class ReceiptEvent : OrderEvent
    {
        public string DeliveryIdentifier { get; set; }
        public DateTime Date { get; set; }

        public List<ReceiptLine> GetReceiptLines()
        {
            
        }

        public void RejectProductInstances(OrderLineIdentifier identifier, RejectedItem rejects)
        {
            
        }
    }
}