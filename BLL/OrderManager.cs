using System;
using System.Collections.Generic;
using Order.Properties;

namespace Order
{
    public class OrderManager
    {
        public void AddOrder(Order order)
        {
            
        }

        public Order FindOrder(OrderIdentifier identifier)
        {
            
        }

        public List<Order> FindOrder(PartySummaryRoleInOrder party, PartySummaryRoleInOrder role)
        {
            
        }

        public List<Order> FindOrder(DateTime start, DateTime end)
        {
            
        }

        public void RemoveOrder(OrderIdentifier id)
        {
            
        }

        public void AddDiscount(DiscountType discountType)
        {
            
        }

        public List<DiscountType> GetDiscountTypes()
        {
            
        }

        public void RemoveDiscountType(DiscountType discountType)
        {
            
        }

        public List<Discount> GetDiscount(Order order)
        {
            
        }
        
        public void AddSalesTaxPolicy(SalesTaxPolicy policy)
        {
            
        }

        public SalesTaxPolicy GetSalesTaxPolicy(string taxationType)
        {
            
        }

        public void RemoveSalesTaxPolicy(string taxationType)
        {
            
        }
    }
}