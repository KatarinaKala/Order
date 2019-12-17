using System;
using BLL.Party;

namespace BLL.Order
{
    public enum OrderEvent
    {
        Processing,
        Despatch,
        Receipt,
        Payment,
        Discount,
        Lifecycle,
        Amend
        
    }
}