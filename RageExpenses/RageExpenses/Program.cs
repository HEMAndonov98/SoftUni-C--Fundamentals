using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadsets = 0, brokenMouses = 0, brokenKeyboards = 0, brokenDisplays = 0;
            double totalExpenses;

            for (int i = 1; i <= numLostGames ; i++)
            {
                if (i % 2 == 0)
                {
                    brokenHeadsets++;
                }

                if (i % 3 == 0)
                {
                    brokenMouses++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    brokenKeyboards++;

                    if (brokenKeyboards % 2 == 0)
                    {
                        brokenDisplays++;
                    }
                }
            }

            totalExpenses = (brokenHeadsets * headsetPrice) + (brokenMouses * mousePrice) + (brokenKeyboards * keyboardPrice) + (brokenDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
