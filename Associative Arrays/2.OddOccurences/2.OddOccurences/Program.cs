using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> occurancies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLowerCase = word.ToLower();

                if (!occurancies.ContainsKey(wordToLowerCase))
                {
                    occurancies.Add(wordToLowerCase, 1);
                    continue;
                }

                occurancies[wordToLowerCase]++;
            }

            string[] oddOccurancies = occurancies.Where(o => o.Value % 2 != 0)
                .Select(o => o.Key).ToArray();

            Console.WriteLine(string.Join(' ', oddOccurancies));
            
        }
    }
}
