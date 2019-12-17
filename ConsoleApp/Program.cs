using System;
using BLL.Order;
using BLL.Party;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var orderLine = new OrderLine(2, "Veepudel", 15);
            var order = new Order(PartySummaryRoleInOrder.Purchaser);
            order.AddOrderLine(orderLine);
            order.GetEvent();
        }
    }
}