using System;

namespace Order
{
    public class OrderEvent
    {
        public OrderIdentifier OrderIdentifier { get; set; }
        public PartySignature Authorization { get; set; }
        public DateTime DateAuthorized { get; set; }
        public bool Processed { get; set; }
        
        //Kas pean kõik klassid siia ka tegema?? Section 9.11
    }
}