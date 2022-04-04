using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{TotalCost(product, quantity):F2}");

        }

        static double TotalCost(string product, int quantity)
        {

            double cost = 0;

            switch (product)
            {
                case "coffee":

                    cost = quantity * 1.50;

                    break;

                case "water":

                    cost = quantity * 1.00;

                    break;

                case "coke":

                    cost = quantity * 1.40;

                    break;

                case "snacks":

                    cost = quantity * 2.00;

                    break;
                        
            }

            return cost;
        }
    }
}
