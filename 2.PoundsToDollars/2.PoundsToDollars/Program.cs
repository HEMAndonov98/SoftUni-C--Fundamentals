using System;

namespace _2.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPounds = decimal.Parse(Console.ReadLine());

            decimal dollars = britishPounds * 1.31m;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
