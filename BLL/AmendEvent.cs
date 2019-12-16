using System;
using BLL.Order;
using BLL.Party;

namespace BLL
{
    /// <summary>
    /// Represents an event sent to an OPEN Order that captures an amendment to the Order
    /// </summary>
    public class AmendEvent : OrderEvent
    {
        public string Reason { get; set; }
    }

    public class AmendOrderLineEvent : AmendEvent
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }

        public OrderLine GetNewOrderLine()
        {
            throw new NotImplementedException();
        }

        public OrderLine GetOriginalOrderLine()
        {
            throw new NotImplementedException();
        }
    }

    public class AmendPartySummaryEvent : AmendEvent
    {
        public OrderLineIdentifier Identifier { get; set; }
        public PartySummaryRoleInOrder Role { get; set; }

        public void GetNewPartySummary()
        {
            throw new NotImplementedException();
        }

        public void GetOriginalPartySummary()
        {
            throw new NotImplementedException();
        }
    }

    public class AmendTermsAndConditionsEvent : AmendEvent
    {
        public string NewTermsAndConditions { get; set; }
        public string OldTermsAndConditions { get; set; }
    }
}