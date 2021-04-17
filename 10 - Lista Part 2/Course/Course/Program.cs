﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Leonardo");
            list.Add("Nicolas");
            list.Add("Mariana");
            list.Add("Tailan");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine($"List Count: {list.Count}");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First Pos A: {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"First Pos A: {pos2}");

            Console.WriteLine("---------------------------------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------------------");

            list.RemoveRange(2, 2);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
