using System;

namespace _6.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddleCharacter(input);
        }

        static void MiddleCharacter(string input)
        {
            int wordLength = input.Length;
            int middleLetter = wordLength / 2;

            if (wordLength % 2 == 0)
            {
                Console.WriteLine($"{input[middleLetter - 1]}{input[middleLetter]}");

                return;
            }

            Console.WriteLine(input[middleLetter]);
        }
    }
}
