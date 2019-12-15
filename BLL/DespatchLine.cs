using System.Collections.Generic;

namespace Order
{
    public class DespatchLine
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }
        public int NumberDispatched { get; set; }

        public int GetNumberDespatched()
        {
            
        }

        public void RejectItems(RejectedItem rejects)
        {
            
        }

        public List<RejectedItem> GetRejectedItems()
        {
            
        }

        public int GetNumberRejected()
        {
            
        }
    }
}