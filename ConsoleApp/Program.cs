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
            var orderLine = new OrderLine(2, "Veepudel", 15, 2.ToString());
            var order = new Order();
            order.AddOrderLine(orderLine);
            order.GetEvent();
        }
    }
}