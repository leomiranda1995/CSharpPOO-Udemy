using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de alturas");
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            double total = 0;

            for (int i=0; i<alturas.Length; i++)
            {
                Console.WriteLine($"Digite a altura {i+1}");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += alturas[i];
            }

            Console.WriteLine($"Média de altura: {(total / n).ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}
