using System;

namespace _2.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sumDigits = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sumDigits += number % 10;
                number /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}
