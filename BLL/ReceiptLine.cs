using System;
using System.Collections.Generic;
using BLL.Order;

namespace BLL
{
    public class ReceiptLine
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }
        public int NumberReceived { get; set; }
        public bool IsAssessed { get; set; }

        public int GetNumberReceived()
        {
            throw new NotImplementedException();
        }

        public void RejectItems(RejectedItem rejects)
        {
            throw new NotImplementedException();
        }

        public List<RejectedItem> GetRejectedItems()
        {
            throw new NotImplementedException();
        }

        public int GetNumberRejected()
        {
            throw new NotImplementedException();
        }

        public int GetNumberAccepted()
        {
            throw new NotImplementedException();
        }
    }
}