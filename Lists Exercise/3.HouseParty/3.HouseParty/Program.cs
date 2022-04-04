using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = command[0];

                var strBuilder = new StringBuilder();

                foreach (var word in command)
                {
                    strBuilder.Append(word + ' ');
                }

                string commandToString = strBuilder.ToString();

                if (commandToString.Contains("is not going!"))
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else if (commandToString.Contains("is going!"))
                {
                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                }
            }

            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
