using System;
using System.Linq;

namespace _2.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string vowels = "aeiouyAEIOUY";

            Console.WriteLine(VowelsCounter(input, vowels));
        }

        static int VowelsCounter(string input, string vowels)
        {
            int vowelsCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    vowelsCounter++;
                }
            }

            return vowelsCounter;
        }
    }
}
