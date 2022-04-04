using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxPassangersPerWagon = int.Parse(Console.ReadLine());

            string rawInput = Console.ReadLine();

            while (rawInput != "end")
            {
                string[] operation = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int n;
                bool IsNumber = int.TryParse(operation[0], out n);

                if (operation[0] == "Add")
                {
                    int passangers = int.Parse(operation[1]);

                    wagons.Add(passangers);
                }
                else if (IsNumber == true)
                {
                    int passangers = int.Parse(operation[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxPassangersPerWagon)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                rawInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
