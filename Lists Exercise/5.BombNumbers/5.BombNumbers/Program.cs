using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool IsBombNumber = numbers[i] == bombNumbers[0];

                if (IsBombNumber)
                {
                    for (int j = i; j >= i - bombNumbers[1] ; j--)
                    {
                        if (j < 0)
                        {
                            break;
                        }
                        numbers[j] = 0;
                    }

                    for (int k = i + 1; k <= i + bombNumbers[1]; k++)
                    {
                        if (k >= numbers.Count)
                        {
                            break;
                        }
                        numbers[k] = 0;
                    }
                }
            }
            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
