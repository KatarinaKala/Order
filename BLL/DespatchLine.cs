using System;
using System.Collections.Generic;
using BLL.Order;

namespace BLL
{
    public class DespatchLine
    {
        public OrderLineIdentifier OrderLineIdentifier { get; set; }
        public int NumberDispatched { get; set; }

        public int GetNumberDespatched()
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
    }
}