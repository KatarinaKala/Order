using System;
using System.Collections.Generic;
using BLL.Order;

namespace BLL
{
    //Represents an event that, when applied to an OPEN SalesOrder,
    //records goods or services sent to a DeliveryReceiver
    public class DespatchEvent : OrderEvent
    {
        public string DespatchIdentifier { get; set; }
        public DateTime Date { get; set; }
        public string ShippingInstructions { get; set; }

        public List<DespatchLine> GetDespatchLines()
        {
            throw new NotImplementedException();
        }

        public void RejectProductInstances(OrderLineIdentifier identifier, RejectedItem rejects)
        {
            throw new NotImplementedException();
        }
    }
}