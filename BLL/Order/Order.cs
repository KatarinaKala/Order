using System;
using System.Collections.Generic;
using BLL.Party;

namespace BLL.Order
{
    public class Order
    {
        private string OrderId = new Random().Next(10000, 100000).ToString();
        public DateTime DateCreated { get; set; } //Mõtle, kas vaja. Panna konstruktorisse?

        public Dictionary<PartySummaryRoleInOrder, PartySummary> PartySummaries =
            new Dictionary<PartySummaryRoleInOrder, PartySummary>();
        public List<OrderLine> OrderLines;
        private List<ChargeLine>? ChargeLines;
        private List<OrderEvent> OrderEvents;
        public OrderStatus OrderStatus;
        public DeliveryReceiver? DeliveryReceiver { get; set; }

        //Manager responsibilities of Order
        public OrderIdentifier GetIdentifier()
        {
            //Return OrderIdentifier
            return new OrderIdentifier(OrderId);
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
                if (orderLine.GetOrderLineIdentifier() == id)
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

        public List<OrderEvent> GetEvents()
        {
            //Return all the OrderEvents that have been applied to this Order 
            return OrderEvents;
        }

        public void ProcessInvoiceEvent()
        {
            //Is overriden by the Order subclasses PurchaseOrder and SalesOrder
            throw new NotImplementedException();
        }

        public OrderStatus GetStatus()
        {
            //Returns the OrderStatus

            return OrderStatus;
        }
    }
}