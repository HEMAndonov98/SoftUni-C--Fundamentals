using System;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += currentDigit;
                }
                bool isValid = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isValid}");
            }
        }
    }
}
