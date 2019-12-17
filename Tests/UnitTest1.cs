using System.Collections.Generic;
using BLL.Order;
using BLL.Party;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        internal Order order;
        internal OrderLine orderLine1;
        internal OrderLine orderLine2;
        
        [SetUp]
        public void Setup()
        {
            order = new Order();
            orderLine1 = new OrderLine(2, "Veepudel", 15);
            orderLine2 = new OrderLine(1, "Vihik", 1);
        }

        [Test]
        public void GetOrderLinesTest()
        {
            order.AddOrderLine(orderLine1);
            order.AddOrderLine(orderLine2);
            List<OrderLine> expected = new List<OrderLine>(){orderLine1, orderLine2};
            Assert.AreEqual(expected, order.GetOrderLines());
        }
    }
}