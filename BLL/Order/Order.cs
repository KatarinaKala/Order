using System;
using System.Collections.Generic;
using BLL.Party;

namespace BLL.Order
{
    public class Order
    {
        public string Id { get; set; } = new Random().Next(10000, 100000).ToString();
        public DateTime DateCreated { get; set; }
        public string SalesChannel { get; set; }
        public string TermsAndConditions { get; set; }
        public RuleContext DiscountContext { get; set; }

        private List<OrderLine> OrderLines { get; set; }
        private List<ChargeLine> ChargeLines { get; set; }

        private List<OrderEvent> OrderEvents { get; set; }

        public Dictionary<PartySummaryRoleInOrder, PartySummary> PartySummaries =
            new Dictionary<PartySummaryRoleInOrder, PartySummary>();

        //Manager responsibilities of Order
        public OrderIdentifier GetIdentifier()
        {
            //Return OrderIdentifier
            return new OrderIdentifier(Id);
        }

        public void AddOrderLine(OrderLine orderLine)
        {
            //Adds an OrderLine to the Order
            OrderLines.Add(orderLine);
        }

        public List<OrderLine> GetOrderLines()
        {
            //Return the collection of OrderLines that constitute the Order
            return OrderLines;
        }

        public void RemoveOrderLine(OrderLineIdentifier id)
        {
            //Remove the specified OrderLine from the Order
            foreach (var orderLine in OrderLines)
            {
                if (orderLine.GetOrderLineIdentifier() == id) //kas siin ei või kasutada orderLine.OrderLineIdentifier
                {
                    OrderLines.Remove(orderLine);
                    return;
                }
            }
        }

        public void AddChargeLine(ChargeLine line)
        {
            ChargeLines.Add(line);
        }

        public List<ChargeLine> GetChargerLines()
        {
            return ChargeLines;
        }

        public void RemoveChargeLine(OrderLineIdentifier id)
        {
            //Remove the specified ChargeLine from the Order
            foreach (var chargeLine in ChargeLines)
            {
                if (chargeLine.OrderLineIdentifier == id)
                {
                    ChargeLines.Remove(chargeLine);
                }
            }
        }

        public void AddPartySummary(PartySummary reference, PartySummaryRoleInOrder role)
        {
            //Add a PartySummary playing the specified PartySummaryRoleInOrder
            PartySummaries.Add(role, reference);
        }

        public PartySummary GetPartySummary(PartySummaryRoleInOrder role)
        {
            //Get the PartySummary playing the specified PartySummaryRoleInOrder
            return PartySummaries[role];
        }

        public void RemovePartySummary(PartySummaryRoleInOrder role)
        {
            //Remove the PartySummary playing the specified PartySummaryRoleInOrder
            PartySummaries.Remove(role);
        }

        //Event responsibilities of Order
        public bool AcceptEvent(OrderEvent orderEvent)
        {
            //Accept an OrderEvent section 9.11
            return orderEvent.Processed;
        }

        public List<OrderEvent> GetEvents()
        {
            //Return all the OrderEvents that have been applied to this Order 
            return OrderEvents;
        }

        public void ProcessDiscountEvent()
        {
            //Add or remove a Discount from the Order
            throw new NotImplementedException();
        }

        public void ProcessLifecycleEvent()
        {
            //Processes events that drive the Order through its lifecycle section 9.12
            throw new NotImplementedException();
        }

        public void ProcessAmendEvent()
        {
            //Make an amendment to the Order
            throw new NotImplementedException();
        }

        public void ProcessInvoiceEvent()
        {
            //Is overriden by the Order subclasses PurchaseOrder and SalesOrder
            throw new NotImplementedException();
        }

        public OrderStatus GetStatus()
        {
            //Returns the OrderStatus section 9.12
            
            throw new NotImplementedException();
        }
    }
}