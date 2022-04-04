using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputLi = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



            string rawInput = Console.ReadLine();

            while (rawInput != "End")
            {
                string[] input = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string opperationToken = input[0];
                string opperationToken2 = input[1];

                if (opperationToken == "Add")
                {
                    int number = int.Parse(input[1]);

                    inputLi.Add(number);
                }
                else if (opperationToken == "Insert")
                {
                    int number = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    if (index < 0 || index > inputLi.Count)
                    {
                        Console.WriteLine("Invalid index");
                        rawInput = Console.ReadLine();
                        continue;
                       
                    }

                    inputLi.Insert(index, number);
                }
                else if (opperationToken == "Remove")
                {
                    int index = int.Parse(input[1]);
                    if (index < 0 || index > inputLi.Count)
                    {
                        Console.WriteLine("Invalid index");
                        rawInput = Console.ReadLine();
                        continue;

                    }

                    inputLi.RemoveAt(index);
                }
                else if (opperationToken == "Shift" && opperationToken2 == "left")
                {
                    int numberOfShifts = int.Parse(input[2]);

                    inputLi = ShiftListLeft(inputLi, numberOfShifts);
                }
                else if (opperationToken =="Shift" && opperationToken2 == "right")
                {
                    int numberOfShifts = int.Parse(input[2]);

                    inputLi = ShiftListRight(inputLi, numberOfShifts);
                }

                rawInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', inputLi));
        }

        static List<int> ShiftListLeft(List<int> inputLi, int numberOfShifts)
        {

            if (numberOfShifts >= inputLi.Count)
            {
                numberOfShifts = numberOfShifts % inputLi.Count;
            }
            List<int> result = inputLi.GetRange(numberOfShifts, inputLi.Count - numberOfShifts);
            result.AddRange(inputLi.GetRange(0, numberOfShifts));

            return result;
        }

        static List<int> ShiftListRight(List<int> inputLi, int numberOfShifts)
        {

            if (numberOfShifts >= inputLi.Count)
            {
                numberOfShifts = numberOfShifts % inputLi.Count;
            }
            List<int> result = inputLi.GetRange(inputLi.Count - numberOfShifts, numberOfShifts);
            result.AddRange(inputLi.GetRange(0, inputLi.Count - numberOfShifts));

            return result;
        }
    }
}
