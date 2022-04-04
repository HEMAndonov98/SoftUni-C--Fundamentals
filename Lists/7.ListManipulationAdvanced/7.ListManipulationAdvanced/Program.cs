using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.ListManipulationAdvanced
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
                string[] input = rawInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string commandToken = input[0];

                if (commandToken == "Contains")
                {
                    int numToken = int.Parse(input[1]);

                    if (nums.Contains(numToken))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandToken == "PrintEven")
                {
                    List<int> evenList = nums.FindAll(x => x % 2 == 0);

                    Console.WriteLine(string.Join(' ', evenList));
                }
                else if (commandToken == "PrintOdd")
                {
                    List<int> oddList = nums.FindAll(x => x % 2 != 0);

                    Console.WriteLine(string.Join(' ', oddList));
                }
                else if (commandToken == "GetSum")
                {
                    int sum = nums.Sum();

                    Console.WriteLine(sum);
                }
                else if (commandToken == "Filter")
                {
                    string condition = input[1];
                    int numToken = int.Parse(input[2]);

                    Console.WriteLine(string.Join(' ', PrintAllNumsThatFufillCondition(condition, numToken, nums)));
                }
            }
        }

        static List<int> PrintAllNumsThatFufillCondition(string condition, int number, List<int> numsList)
        {
            List<int> filteredList = new List<int>();

            if (condition == ">")
            {
                filteredList = numsList.FindAll(x => x > number);
            }
            else if (condition == "<")
            {
                filteredList = numsList.FindAll(x => x < number);
            }
            else if (condition == ">=")
            {
                filteredList = numsList.FindAll(x => x >= number);
            }
            else if (condition == "<=")
            {
                filteredList = numsList.FindAll(x => x <= number);
            }

            return filteredList;
        }
    }
}
