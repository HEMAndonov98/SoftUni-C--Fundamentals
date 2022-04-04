using System;
using System.Linq;

namespace _4.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            for (int rotations = 1; rotations <= rotationsCount; rotations++)
            {
                int firstEl = rawInput[0];
                for (int i = 0; i < rawInput.Length - 1; i++)
                {
                    rawInput[i] = rawInput[i + 1];
                }
                rawInput[rawInput.Length - 1] = firstEl;
            }

            Console.WriteLine(string.Join(' ', rawInput));
        }
    }
}
