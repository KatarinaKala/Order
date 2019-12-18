using System;
using BLL.Order;
using BLL.Party;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderLine = new OrderLine(2, "Veepudel", 15, 2.ToString());
            var order = new Order(1.ToString());
            order.AddOrderLine(orderLine);
            order.GetEvent();
        }
    }
}