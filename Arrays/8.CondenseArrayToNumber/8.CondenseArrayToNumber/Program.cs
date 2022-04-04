using System;
using System.Linq;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();



            for (int i = 0; i < nums.Length - 1; i++)
            {
                int[] condensed = new int[nums.Length];

                for (int j = 0; j < nums.Length - 1; j++)
                {
                    condensed[j] = nums[j] +nums[j + 1];
                }
                nums = condensed;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
