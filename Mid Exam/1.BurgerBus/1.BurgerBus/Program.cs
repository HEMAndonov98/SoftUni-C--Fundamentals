using System;

namespace _1.BurgerBus
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal cityProfit = 0m;
            decimal totalProfit = 0m;
            int trip = 0;
            int numberOfCities = int.Parse(Console.ReadLine());


            while (trip < numberOfCities)
            {

                string cityName = Console.ReadLine();

                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                trip++;

                if (trip % 5 == 0)
                {
                    income -= income * 0.1m;
                }
                else if (trip % 3 == 0)
                {
                    expenses += expenses * 0.5m;
                }

                cityProfit = income - expenses;
                totalProfit += cityProfit;

                Console.WriteLine($"In {cityName} Burger Bus earned {cityProfit:F2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
        }
    }
}
