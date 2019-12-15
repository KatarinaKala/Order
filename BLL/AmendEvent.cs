using Order.Properties;

namespace Order
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
            
        }

        public OrderLine GetOriginalOrderLine()
        {
            
        }
    }

    public class AmendPartySummaryEvent : AmendEvent
    {
        public OrderLineIdentifier Identifier { get; set; }
        public PartySummaryRoleInOrder Role { get; set; }

        public void GetNewPartySummary()
        {
            
        }

        public void GetOriginalPartySummary()
        {
            
        }
    }

    public class AmendTermsAndConditionsEvent : AmendEvent
    {
        public string NewTermsAndConditions { get; set; }
        public string OldTermsAndConditions { get; set; }
    }
}