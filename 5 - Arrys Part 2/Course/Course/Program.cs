using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];
            double totalPreco = 0;

            for(int i=0; i<produtos.Length; i++)
            {
                produtos[i] = new Produto();

                Console.WriteLine($"Nome {i+1}");
                produtos[i].Nome = Console.ReadLine();

                Console.WriteLine("Preço");
                produtos[i].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                totalPreco += produtos[i].Preco;
            }

            Console.WriteLine($"Média de preços: {(totalPreco / n).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
