using System;

namespace _10.MultiplyEvenByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int evenSum = EvenDigit(input);
            int oddSum = OddDigit(input);

            Console.WriteLine($"{evenSum * oddSum}");
        }

        static int EvenDigit(int input)
        {
            int currentDigit = 0;
            int evenSum = 0;

            while (input > 0)
            {
                currentDigit = input % 10;

                if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }

                input /= 10;
            }

            return evenSum;
        }

        static int OddDigit(int input)
        {
            int currentDigit = 0;
            int oddSum = 0;

            while (input > 0)
            {
                currentDigit = input % 10;

                if (currentDigit % 2 != 0)
                {
                    oddSum += currentDigit;
                }

                input /= 10;
            }

            return oddSum;
        }
    }
}
