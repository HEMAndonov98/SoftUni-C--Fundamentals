using System;
using System.Collections.Generic;

namespace _3.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> notebook = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            string[] inputCollection = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var collection in inputCollection)
            {
                string[] splitCollection = collection.Split(": ");
                string word = splitCollection[0];
                string definition = splitCollection[1];

                if (!notebook.ContainsKey(word))
                {
                    notebook[word] = new List<string>();
                }

                notebook[word].Add(definition);
            }

            string[] secondCommand = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            string task = Console.ReadLine();

            if (task == "Test")
            {
                foreach (var word in secondCommand)
                {
                    if (notebook.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");

                        foreach (var definition in notebook[word])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }

            }
            else if (task == "Hand Over")
            {
                Console.WriteLine(string.Join(' ', notebook.Keys));
            }

        }
    }
}
