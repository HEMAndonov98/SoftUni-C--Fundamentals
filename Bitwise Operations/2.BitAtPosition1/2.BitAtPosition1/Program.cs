using System;

namespace _2.BitAtPosition1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPos1 = (n >> 1) & 1;

            Console.WriteLine(bitAtPos1);
        }
    }
}
