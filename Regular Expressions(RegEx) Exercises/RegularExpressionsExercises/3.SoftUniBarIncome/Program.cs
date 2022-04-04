using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<client>[A-Z][a-z]+)%[^|$%.]*?\<(?<product>\w+)\>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+[.\d]*)\$";
            decimal totalIncome = 0m;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match orderInfo = Regex.Match(input, pattern);

                if (orderInfo.Success)
                {
                    string client = orderInfo.Groups["client"].Value;
                    string product = orderInfo.Groups["product"].Value;
                    int count = int.Parse(orderInfo.Groups["count"].Value);
                    decimal price = decimal.Parse(orderInfo.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{client}: {product} - {totalPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }

    }
}
