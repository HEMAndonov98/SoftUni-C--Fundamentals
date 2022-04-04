using System;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rawInput = Console.ReadLine().Split(' ');
            Array.Reverse(rawInput);

            foreach (var item in rawInput)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
