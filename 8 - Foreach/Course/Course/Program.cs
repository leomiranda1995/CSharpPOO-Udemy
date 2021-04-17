using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] vetor = new string[] { "Maria", "Bob", "Alex" };

            foreach(string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
