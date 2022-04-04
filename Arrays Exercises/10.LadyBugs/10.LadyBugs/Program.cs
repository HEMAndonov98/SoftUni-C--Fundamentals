using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];

            int[] initIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < fieldSize; i++)
            {
                if (initIndexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int startingIndex = int.Parse(cmdArgs[0]);
                string flightDirection = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (startingIndex < 0 || startingIndex >= field.Length)
                {
                    continue;
                }

                if (field[startingIndex] == 0)
                {
                    continue;
                }

                int nextIndex = startingIndex;
                field[startingIndex] = 0;

                while (true)
                {
                    if (flightDirection == "left")
                    {
                        nextIndex -= flyLength;
                    }
                    else if (flightDirection == "right")
                    {
                        nextIndex += flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= fieldSize)
                    {
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        break;
                    }

                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}
