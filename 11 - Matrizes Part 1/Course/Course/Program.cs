using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);           // quantidade de elementos da matriz
            Console.WriteLine(matriz.Rank);             // linhas da matriz
            Console.WriteLine(matriz.GetLength(0));     // linhas da matriz
            Console.WriteLine(matriz.GetLength(1));     // colunas da matriz

        }
    }
}
