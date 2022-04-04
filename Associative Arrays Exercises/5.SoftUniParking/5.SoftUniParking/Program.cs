using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string cmdType = commandArgs[0];
                string username = commandArgs[1];

                if (cmdType == "register")
                {
                    RegisterUser(parkingRegister, username, commandArgs);
                }
                else if (cmdType == "unregister")
                {
                    UnregisterUser(parkingRegister, username);
                }
            }

            PrintRegister(parkingRegister);
        }
        static void RegisterUser(Dictionary<string, string> parkingRegister, string username, string[] commandArgs)
        {
            string licensePlate = commandArgs[2];

            if (parkingRegister.ContainsKey(username))
            {

                string registeredLicensePlate = parkingRegister[username];
                Console.WriteLine($"ERROR: already registered with plate number {registeredLicensePlate}");

            }
            else
            {

                parkingRegister[username] = licensePlate;
                Console.WriteLine($"{username} registered {licensePlate} successfully");
            }
        }

        static void UnregisterUser(Dictionary<string, string> parkingRegister, string username)
        {
            if (!parkingRegister.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                parkingRegister.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");
            }
        }

        static void PrintRegister(Dictionary<string, string> parkingRegister)
        {
            foreach (var kvp in parkingRegister)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
