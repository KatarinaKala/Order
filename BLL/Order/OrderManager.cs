using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Party;

namespace BLL.Order
{
    public class OrderManager
    {
        //Erinevad allahindlused, käibemaksureeglid tellimusel
        private List<Order>? _orders;
        private List<SalesTaxPolicy> _salesTaxPolicies;
        private List<Discount>? _discounts;

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public Order FindOrder(OrderIdentifier identifier)
        {
          return _orders.Single(order => order.GetIdentifier() == identifier);
        }

        public void RemoveOrder(OrderIdentifier id)
        {
            foreach (var order in _orders)
            {
                if (order.GetIdentifier() == id)
                {
                    _orders.Remove(order);
                }
            }
        }

        public void AddDiscount(Discount discount)
        {
            _discounts.Add(discount);
        }

        public List<Discount> GetDiscounts()
        {
            return _discounts;
        }

        public void RemoveDiscount(Discount discount)
        {
            _discounts.Remove(discount);
        }

        public List<Discount> GetDiscount(Order order)
        {
            throw new NotImplementedException();
        }

        public void AddSalesTaxPolicy(SalesTaxPolicy policy)
        {
            _salesTaxPolicies.Add(policy);
        }

        public SalesTaxPolicy GetSalesTaxPolicy(string taxationType)
        {
            //return _orders.Single(order => order.GetIdentifier() == identifier);
            
            throw new NotImplementedException();
            /*foreach (var policy in _salesTaxPolicies)
            {
                if (policy._taxationType == taxationType)
                {
                    return policy;
                }
            }*/

            //return _salesTaxPolicies.Where(policy => policy._taxationType == taxationType);
        }

        public void RemoveSalesTaxPolicy(SalesTaxPolicy policy)
        {
            _salesTaxPolicies.Remove(policy);
        }
    }
}