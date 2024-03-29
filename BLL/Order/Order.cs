using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Party;

namespace BLL.Order
{
    public class Order
    {
        private OrderIdentifier OrderId;
        public DateTime DateCreated { get; set; }

        public Dictionary<PartySummaryRoleInOrder, PartySummary> PartySummaries = 
            new Dictionary<PartySummaryRoleInOrder, PartySummary>();
        public List<OrderLine> OrderLines = new List<OrderLine>();
        public List<ChargeLine>? ChargeLines = new List<ChargeLine>();
        public OrderEvent Event;
        public OrderStatus Status;

        public Order(string identifier)
        {
            OrderId = new OrderIdentifier(identifier);
        }

        public DeliveryReceiver? DeliveryReceiver { get; set; }

        //Manager responsibilities of Order
        public OrderIdentifier GetIdentifier()
        {
            //Return OrderIdentifier
            return OrderId;
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
            //ChargeLines = ChargeLines.Where(line => line.OrderLineIdentifier != id).ToList();
            OrderLines = OrderLines.Where(line => line.GetOrderLineIdentifier() != id).ToList();
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
            ChargeLines = ChargeLines.Where(line => line.OrderLineIdentifier != id).ToList();
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

        public OrderEvent GetEvent()
        {
            //Return OrderEvent 
            return Event;
        }

        public void ProcessInvoiceEvent()
        {
            //Is overriden by the Order subclasses PurchaseOrder and SalesOrder
            throw new NotImplementedException();
        }

        public OrderStatus GetStatus()
        {
            //Returns the OrderStatus

            return Status;
        }

        public double TotalSum()
        {
            double totalsum = 0;
            
            foreach (var line in OrderLines)
            {
                totalsum += line.TotalSum();
            }
            
            if (ChargeLines != null)
            {
                foreach (var charge in ChargeLines)
                {
                    totalsum += charge.Amount;
                }
            }

            return totalsum;
        }
    }
}