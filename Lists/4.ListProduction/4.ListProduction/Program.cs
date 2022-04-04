using System;
using System.Collections.Generic;

namespace _4.ListProduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            int index = 1;

            foreach (var product in products)
            {
                Console.WriteLine($"{index}.{product}");
                index++;
            }
        }
    }
}
