using System;
using BLL.Order;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var orderLine = new OrderLine();
            orderLine.numberOrdered = 2;
            var order = new Order();
            order.AddOrderLine(orderLine);
        }
    }
}