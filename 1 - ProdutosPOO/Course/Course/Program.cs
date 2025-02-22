﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produo:");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
            int qtd = int.Parse(Console.ReadLine());
           
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque:");
            qtd = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");
        }
    }
}
