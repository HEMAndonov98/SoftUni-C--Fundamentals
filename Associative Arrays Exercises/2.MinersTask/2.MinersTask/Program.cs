using System;
using System.Collections.Generic;

namespace _2.MinersTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, long> resorces = new Dictionary<string, long>();

            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                string resorce = input;
                int resorceQty = int.Parse(Console.ReadLine());

                if (!resorces.ContainsKey(resorce))
                {
                    resorces[resorce] = 0;
                }

                resorces[resorce] += resorceQty;
            }

            foreach (var kvp in resorces)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
