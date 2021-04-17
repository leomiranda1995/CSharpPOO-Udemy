using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t5);

            Console.WriteLine(t4 - t3);
        }
    }
}
