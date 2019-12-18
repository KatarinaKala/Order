using System.Collections.Generic;
using BLL;
using BLL.Order;
using BLL.Party;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        internal Order Order;
        internal OrderLine OrderLine1;
        internal OrderLine OrderLine2;
        internal ChargeLine ChargeLine1;
        internal ChargeLine ChargeLine2;
        internal PartySummary Mari;
        internal PartySummary Peeter;
        internal DeliveryReceiver DeliveryReceiver;
        internal TaxOnLine tax1;
        internal TaxOnLine tax2;
        
        [SetUp]
        public void Setup()
        {
            Order = new Order();
            OrderLine1 = new OrderLine(2, "Veepudel", 15, 1.ToString());
            OrderLine2 = new OrderLine(1, "Vihik", 1, 2.ToString());
            ChargeLine1 = new ChargeLine(15, 3.ToString());
            ChargeLine2 = new ChargeLine(10, 4.ToString());
            Mari = new PartySummary("Mari", "Akadeemia tee", 5123456, "mari@gmail.com");
            Peeter = new PartySummary("Peeter", "Nõmme tee", 5678910, "peeter@gmail.com");
            DeliveryReceiver = new DeliveryReceiver("Siim", "Tedre", 564737, "siim@gmail.com");
            tax1 = new TaxOnLine(0.2, "Käibemaks");
            tax2 = new TaxOnLine(0.1, "Maks");
        }

        [Test]
        public void AddOrderLinesTest()
        {
            Order.AddOrderLine(OrderLine1);
            Order.AddOrderLine(OrderLine2);
            List<OrderLine> expected = new List<OrderLine>(){OrderLine1, OrderLine2};
            Assert.AreEqual(expected, Order.GetOrderLines());
        }
        
        [Test]
        public void RemoveOrderLinesTest()
        {
            Order.AddOrderLine(OrderLine1);
            Order.AddOrderLine(OrderLine2);
            Order.RemoveOrderLine(OrderLine2.GetOrderLineIdentifier());
            
            List<OrderLine> expected = new List<OrderLine>(){OrderLine1};
            Assert.AreEqual(expected, Order.GetOrderLines());
        }
        
        [Test]
        public void AddChargeLinesTest()
        {
            Order.AddChargeLine(ChargeLine1);
            Order.AddChargeLine(ChargeLine2);
            List<ChargeLine> expected = new List<ChargeLine>(){ChargeLine1, ChargeLine2};
            Assert.AreEqual(expected, Order.GetChargerLines());
        }
        
        [Test]
        public void RemoveChargeLinesTest()
        {
            Order.AddChargeLine(ChargeLine1);
            Order.AddChargeLine(ChargeLine2);
            Order.RemoveChargeLine(ChargeLine2.OrderLineIdentifier);
            
            List<ChargeLine> expected = new List<ChargeLine>(){ChargeLine1};
            Assert.AreEqual(expected, Order.GetChargerLines());
        }
        
        [Test]
        public void AddPartySummaryTest()
        {
            Order.AddPartySummary(Mari, PartySummaryRoleInOrder.Vendor);
            Order.AddPartySummary(Peeter, PartySummaryRoleInOrder.Purchaser);
            Assert.AreEqual(Mari, Order.GetPartySummary(PartySummaryRoleInOrder.Vendor));
        }
        
        [Test]
        public void RemovePartySummaryTest()
        {
            Order.AddPartySummary(Mari, PartySummaryRoleInOrder.Vendor);
            Order.AddPartySummary(Peeter, PartySummaryRoleInOrder.Purchaser);
            Order.RemovePartySummary(PartySummaryRoleInOrder.Vendor);
            
            Dictionary<PartySummaryRoleInOrder, PartySummary> expected = 
                new Dictionary<PartySummaryRoleInOrder, PartySummary>()
                    {{PartySummaryRoleInOrder.Purchaser, Peeter}};
            
            Assert.AreEqual(expected, Order.PartySummaries);
        }

        [Test]
        public void GetEventTest()
        {
            Order.Event = OrderEvent.Despatch;
            OrderEvent expected = OrderEvent.Despatch;
            Assert.AreEqual(expected, Order.Event);
        }
        
        [Test]
        public void GetStatusTest()
        {
            Order.Status = OrderStatus.Cancelled;
            OrderStatus expected = OrderStatus.Cancelled;
            Assert.AreEqual(expected, Order.Status);
        }
        
        [Test]
        public void GetNumberOrderedTest()
        {
            Assert.AreEqual(2, OrderLine1.GetNumberOrdered());
        }
        
        [Test]
        public void IncrementNumberOrderedTest()
        {
            OrderLine1.IncrementNumberOrdered(2);
            Assert.AreEqual(4, OrderLine1.GetNumberOrdered());
        }
        
        [Test]
        public void DecrementNumberOrderedTest()
        {
            OrderLine1.DecrementNumberOrdered(1);
            Assert.AreEqual(1, OrderLine1.GetNumberOrdered());
        }
        
        [Test]
        public void AddDeliveryReceiverTest()
        {
            OrderLine1.AddDeliveryReceiver(DeliveryReceiver);
            Assert.AreEqual(DeliveryReceiver, OrderLine1.GetDeliveryReceiver());
        }
        
        [Test]
        public void RemoveDeliveryReceiverTest()
        {
            OrderLine1.AddDeliveryReceiver(DeliveryReceiver);
            OrderLine1.RemoveDeliveryReceiver();
            Assert.AreEqual(null, OrderLine1.GetDeliveryReceiver());
        }
        
        [Test]
        public void AddTaxLinesTest()
        {
            OrderLine1.AddTax(tax1);
            OrderLine1.AddTax(tax2);
            List<TaxOnLine> expected = new List<TaxOnLine>(){tax1, tax2};
            Assert.AreEqual(expected, OrderLine1.GetTaxes());
        }
        
        [Test]
        public void RemoveTaxLinesTest()
        {
            OrderLine1.AddTax(tax1);
            OrderLine1.AddTax(tax2);
            OrderLine1.RemoveTax(tax1);
            
            List<TaxOnLine> expected = new List<TaxOnLine>(){tax2};
            Assert.AreEqual(expected, OrderLine1.GetTaxes());
        }
    }
}