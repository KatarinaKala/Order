using System;
using System.Collections.Generic;
using Order.Properties;

namespace Order
{
    public class Order
    {
        //Section 9.3
        public DateTime DateCreated { get; set; }
        public string SalesChannel { get; set; }
        public string TermsAndConditions { get; set; }
        public RuleContext DiscountContext { get; set; } //Eraldi mustrist Rule pärit

        public List<OrderLine> OrderLines { get; set; }
        //Manager responsibilities of Order
        public OrderIdentifier GetIdentifier()
        {
            //Return OrderIdentifier
            return new OrderIdentifier();
        }
        
        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
        }

        public List<OrderLine> GetOrderLines()
        {
            //?Return the collection of OrderLines that constitute the Order
            return OrderLines;
        }

        public void RemoveOrderLine(OrderLineIdentifier id)
        {
            OrderLines.RemoveAll(orderLine => orderLine.GetOrderLineIdentifier() == id);
            //?Remove the specified OrderLine from the Order
            foreach (var orderLine in OrderLines)
            {
                if (orderLine.GetOrderLineIdentifier() == id)
                {
                    OrderLines.Remove(orderLine);
                    return;
                }
            }
        }

        public void AddChargeLine(ChargeLine line)
        {
            //Add a ChargerLine to the Order section 9.8
        }

        public List<ChargeLine> GetChargerLines()
        {
            //Return the collection of ChargerLines for the Order
        }

        public void RemoveChargeLine(OrderLineIdentifier id)
        {
            //Remove the specified ChargeLine from the Order
        }

        public void AddPartySummary(PartySummary reference, PartySummaryRoleInOrder role)
        {
            //Add a PartySummary playing the specified PartySummaryRoleInOrder section 9.6
        }
        
        public PartySummary GetPartySummary(PartySummaryRoleInOrder role)
        {
            //Get the PartySummary playing the specified PartySummaryRoleInOrder
        }
        
        public void RemovePartySummary(PartySummaryRoleInOrder role)
        {
            //Remove the PartySummary playing the specified PartySummaryRoleInOrder
        }

        //Event responsibilities of Order
        public bool AcceptEvent(OrderEvent orderEvent)
        {
            //Accept an OrderEvent section 9.11
        }

        public List<OrderEvent> GetEvents()
        {
            //Return all the OrderEvents that have been applied to this Order 
        }

        public void ProcessDiscountEvent()
        {
            //Add or remove a Discount from the Order
        }

        public void ProcessLifecycleEvent()
        {
            //Processes events that drive the Order through its lifecycle section 9.12
        }

        public void ProcessAmendEvent()
        {
            //Make an amendment to the Order
        }

        public void ProcessInvoiceEvent()
        {
            //Is overriden by the Order subclasses PurchaseOrder and SalesOrder section 9.4
        }

        public OrderStatus GetStatus()
        {
            //Returns the OrderStatus section 9.12
        }
    }

}