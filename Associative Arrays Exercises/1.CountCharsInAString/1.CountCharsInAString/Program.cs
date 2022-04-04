using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string trimmedInput = string.Concat(input.Where(c => !char.IsWhiteSpace(c)));

            char[] characters = trimmedInput.ToCharArray();

            Dictionary<char, int> occurancies = new Dictionary<char, int>();

            foreach (char character in characters)
            {
                if (!occurancies.ContainsKey(character))
                {
                    occurancies[character] = 1;
                    continue;
                }

                occurancies[character]++;
            }

            foreach (var kvp in occurancies)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
