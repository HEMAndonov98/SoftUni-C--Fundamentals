using System;
using System.Linq;

namespace _6.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int evenNum = 0;
            int oddNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNum += numbers[i];
                }
                else
                {
                    oddNum += numbers[i];
                }
            }

            Console.WriteLine($"{evenNum - oddNum}");
        }
    }
}
