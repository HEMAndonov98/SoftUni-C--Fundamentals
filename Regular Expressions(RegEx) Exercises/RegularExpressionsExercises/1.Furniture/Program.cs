using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+(\.\d+)*)!(?<count>\d+)";
            List<string> furniture = new List<string>();
            decimal totalCost = 0m;

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match order = Regex.Match(input, pattern);

                if (order.Success)
                {
                    furniture.Add(order.Groups["name"].Value);
                    decimal price = decimal.Parse(order.Groups["price"].Value);
                    int count = int.Parse(order.Groups["count"].Value);

                    totalCost += count * price;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }

    }
}
