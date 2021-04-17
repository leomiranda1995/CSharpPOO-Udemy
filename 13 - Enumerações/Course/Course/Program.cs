using System;
using Course.Entities;
using Course.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            Order order = new Order(1080,DateTime.Now, OrderStatus.Processing);
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
