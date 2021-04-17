using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            List<int> diagonalPrincipal = new List<int>();
            int totNegativos = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Digite o valor da posição {i},{j}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                    {
                        diagonalPrincipal.Add(matriz[i, j]);
                    }

                    if (matriz[i, j] < 0)
                    {
                        totNegativos++;
                    }
                }
            }

            Console.Write("Diagonal principal: ");
            foreach(int element in diagonalPrincipal)
            {
                Console.Write($"{element}, ");
            }

            Console.WriteLine();
            Console.WriteLine($"Total de números negaivos: {totNegativos}");
        }
    }
}
