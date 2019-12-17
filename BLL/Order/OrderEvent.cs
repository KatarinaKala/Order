using System;
using BLL.Party;

namespace BLL.Order
{
    public enum OrderEvent
    {
        Despatch,
        Receipt,
        Payment,
        Discount,
        Lifecycle,
        Amend
        
    }
}