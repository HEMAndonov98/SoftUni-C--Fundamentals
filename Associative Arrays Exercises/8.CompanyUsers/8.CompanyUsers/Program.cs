using System;
using System.Collections.Generic;

namespace _8.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyRegistry = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] employeeArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = employeeArgs[0];
                string employeeID = employeeArgs[1];

                if (!companyRegistry.ContainsKey(companyName))
                {
                    companyRegistry[companyName] = new List<string>();
                }

                if (companyRegistry[companyName].Contains(employeeID))
                {
                    continue;
                }

                companyRegistry[companyName].Add(employeeID);
            }

            foreach (var kvp in companyRegistry)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
