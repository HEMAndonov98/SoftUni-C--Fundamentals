using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|')
                .ToArray();

            List<int> outputList = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {

                List<int> arrList = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                outputList.AddRange(arrList);
            }

            Console.WriteLine(string.Join(' ', outputList));
        }
    }
}
