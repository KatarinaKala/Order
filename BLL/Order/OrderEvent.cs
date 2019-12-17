using System;
using BLL.Party;

namespace BLL.Order
{
    public class OrderEvent
    {
        //Võid enumiga kirjutada erinevad sündmused)
        public OrderIdentifier OrderIdentifier { get; set; }
        public PartySignature Authorization { get; set; }
        public DateTime DateAuthorized { get; set; }
        public bool Processed { get; set; }
        
    }
}