using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] rawInput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commandToken = rawInput[0];
                int value = int.Parse(rawInput[1]);

                if (commandToken == "Add")
                {
                    numbers.Insert(numbers.Count, value);
                }
                else if (commandToken == "Remove")
                {
                    numbers.Remove(value);
                }
                else if (commandToken == "Replace")
                {
                    int index = numbers.IndexOf(value);
                    int replacer = int.Parse(rawInput[2]);

                    if (index != -1)
                    {
                        numbers[index] = replacer;
                    }
                }
                else if (commandToken == "Collapse")
                {
                    numbers.RemoveAll(x => x < value);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
