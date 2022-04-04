using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int extracted = 0;
            int daysMined = 0;

            while (startingYeld >= 100)
            {
                daysMined++;
                extracted += (startingYeld - 26);
                startingYeld -= 10;
            }

            Console.WriteLine(daysMined);
            if (extracted < 26)
            {
                Console.WriteLine(extracted);
            }
            else
            {
                Console.WriteLine($"{extracted - 26}");
            }
        }
    }
}
