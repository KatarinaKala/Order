using System.Collections.Generic;

namespace Order
{
    public class ReceiptLine
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }
        public int NumberReceived { get; set; }
        public bool IsAssessed { get; set; }

        public int GetNumberReceived()
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

        public int GetNumberAccepted()
        {
            
        }
    }
}