using System;
using System.Linq;

namespace _1.EncryptSortAndPrintArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sumArr = new int[n];
            int sumArrIndex = 0;

            string vowels = "AaEeIiOoUu";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                foreach (var character in input)
                {
                    if (vowels.Contains(character))
                    {
                        sumArr[sumArrIndex] += character * input.Length;
                    }
                    else
                    {
                        sumArr[sumArrIndex] += character / input.Length;
                    }
                }
                sumArrIndex++;
            }

            Array.Sort(sumArr);

            for (int i = 0; i < sumArr.Length; i++)
            {
                Console.WriteLine(sumArr[i]);
            }
        }
    }
}
