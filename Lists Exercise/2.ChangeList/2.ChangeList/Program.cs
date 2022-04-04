using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string rawInput = Console.ReadLine();

            while (rawInput != "end")
            {
                string[] commands = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string operationToken = commands[0];
                int elementToken = int.Parse(commands[1]);

                if (operationToken == "Delete")
                {
                    nums.RemoveAll(x => x == elementToken);
                }
                else if (operationToken == "Insert")
                {
                    int positionToken = int.Parse(commands[2]);

                    if (positionToken >= 0 && positionToken <= nums.Count)
                    {
                        nums.Insert(positionToken, elementToken);
                    }
                }

                rawInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
