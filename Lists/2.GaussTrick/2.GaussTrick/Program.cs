using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int lastEl = numbers.Count - 1;
            int listLength = numbers.Count;

            for (int i = 0; i < listLength / 2; i++)
            {
                numbers[i] += numbers[lastEl - i];
                numbers.RemoveAt(lastEl - i);
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
