using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n]; //Arrays where ill put the zig zag nums
            int[] arr2 = new int[n];

            for (int rows = 1; rows <= n; rows++)
            {
                int[] currentData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (rows % 2 != 0)
                {
                    arr1[rows - 1] = currentData[0];
                    arr2[rows - 1] = currentData[1];
                }
                else
                {
                    arr2[rows - 1] = currentData[0];
                    arr1[rows - 1] = currentData[1];
                }
            }

            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
