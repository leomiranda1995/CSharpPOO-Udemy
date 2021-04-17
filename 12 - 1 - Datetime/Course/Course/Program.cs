using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            //Console.WriteLine(data);
            //Console.WriteLine(data.Ticks);

            DateTime data2 = new DateTime(2021, 04, 16);
            //Console.WriteLine(data2);

            DateTime data3 = new DateTime(2021, 04, 16, 21, 20, 00);
            //Console.WriteLine(data3);

            DateTime data4 = new DateTime(2021, 04, 16, 21, 21, 3);
            //Console.WriteLine(data4);

            DateTime data5 = DateTime.Today;
            //Console.WriteLine(data5);

            DateTime data6 = DateTime.UtcNow;
            //Console.WriteLine(data6);

            DateTime data7 = DateTime.Parse("2000-08-15");
            Console.WriteLine(data7);

            DateTime data8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(data8);

            DateTime data9 = DateTime.Parse("15/08/2000");
            Console.WriteLine(data9);

            DateTime data10 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(data10);

            DateTime data11 = DateTime.ParseExact("2021-04-16", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(data11);

            DateTime data12 = DateTime.ParseExact("23/07/2013 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(data12);
        }
    }
}
