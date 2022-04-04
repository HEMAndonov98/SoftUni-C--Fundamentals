using System;

namespace _1.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(GetSmallestNum(numbers));
        }

        static int GetSmallestNum(int[] numbers)
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNum)
                {
                    smallestNum = numbers[i];
                }
            }

            return smallestNum;
        }
    }
}
