using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Discount;
using BLL.Party;

namespace BLL.Order
{
    public class OrderManager
    {
        private List<Order> Orders { get; set; }
        

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public Order FindOrder(OrderIdentifier identifier)
        {
            return Orders.Single(order => order.GetIdentifier() == identifier);
        }

        public List<Order> FindOrder(PartySummaryRoleInOrder party, PartySummaryRoleInOrder role)
        {
            // return Orders.Where(order => order.PartySummaries[party] == role);
            throw new NotImplementedException();
        }

        public List<Order> FindOrder(DateTime start, DateTime end)
        {
            return Orders.FindAll(order => order.DateCreated == start && order.DateCreated == end);
        }

        public void RemoveOrder(OrderIdentifier id)
        {
            Orders = (List<Order>) Orders.Where(order => order.GetIdentifier() != id);
        }

        public void AddDiscount(DiscountType discountType)
        {
            throw new NotImplementedException();
        }

        public List<DiscountType> GetDiscountTypes()
        {
            throw new NotImplementedException();
        }

        public void RemoveDiscountType(DiscountType discountType)
        {
            throw new NotImplementedException();
        }

        public List<Discount.Discount> GetDiscount(Order order)
        {
            throw new NotImplementedException();
        }

        public void AddSalesTaxPolicy(SalesTaxPolicy policy)
        {
            throw new NotImplementedException();
        }

        public SalesTaxPolicy GetSalesTaxPolicy(string taxationType)
        {
            throw new NotImplementedException();
        }

        public void RemoveSalesTaxPolicy(string taxationType)
        {
            throw new NotImplementedException();
        }
    }
}