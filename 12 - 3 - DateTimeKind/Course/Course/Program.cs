using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1");
            Console.WriteLine($"{d1}\n{d1.Kind}\n{d1.ToLocalTime()}\n{d1.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine("d2");
            Console.WriteLine($"{d2}\n{d2.Kind}\n{d2.ToLocalTime()}\n{d2.ToUniversalTime()}");
            Console.WriteLine();

            Console.WriteLine("d3");
            Console.WriteLine($"{d3}\n{d3.Kind}\n{d3.ToLocalTime()}\n{d3.ToUniversalTime()}");
            Console.WriteLine();

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine(d5);
        }
    }
}
