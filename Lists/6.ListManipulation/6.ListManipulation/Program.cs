using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] rawIput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandToken = rawIput[0];

                switch (commandToken)
                {
                    case "Add":
                        int numToken = int.Parse(rawIput[1]);
                        int lastIndex = nums.Count;

                        nums.Insert(lastIndex, numToken);
                        break;

                    case "Remove":
                        int numToRemove = int.Parse(rawIput[1]);

                        nums.Remove(numToRemove);
                        break;

                    case "RemoveAt":
                        int indexToken = int.Parse(rawIput[1]);

                        nums.RemoveAt(indexToken);
                        break;

                    case "Insert":
                        numToken = int.Parse(rawIput[1]);
                        indexToken = int.Parse(rawIput[2]);

                        nums.Insert(indexToken, numToken);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
