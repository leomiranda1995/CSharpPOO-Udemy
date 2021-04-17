using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            int s1 = calc.sum(1, 2, 3, 4, 5);
            Console.WriteLine(s1);
        }
    }
}
