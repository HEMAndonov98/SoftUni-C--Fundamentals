using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"!(?<command>[A-Z]{1,}[a-z]{2,})!:\[(?<string>[A-za-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match translates = Regex.Match(input, pattern);
                if (translates.Success)
                {
                    string command = translates.Groups["command"].Value;
                    string word = translates.Groups["string"].Value;
                    List<int> numbers = new List<int>();

                    foreach (var letter in word)
                    {
                        numbers.Add(letter);
                    }

                    Console.WriteLine($"{command}: {string.Join(' ', numbers)}");

                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }

            }
        }
    }
}
