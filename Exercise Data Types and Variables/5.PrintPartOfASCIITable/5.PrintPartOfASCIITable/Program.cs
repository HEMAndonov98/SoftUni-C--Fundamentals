using System;

namespace _5.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCharIndex = int.Parse(Console.ReadLine());
            int lastCharIndex = int.Parse(Console.ReadLine());

            for (int i = startCharIndex; i <= lastCharIndex; i++)
            {
                char currentChar = (char)i;
                Console.Write($"{currentChar} ");
            }
        }
    }
}
