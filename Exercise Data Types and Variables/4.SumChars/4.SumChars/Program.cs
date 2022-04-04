using System;

namespace _4.SumChars
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                sumOfChars += (int)inputChar;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
