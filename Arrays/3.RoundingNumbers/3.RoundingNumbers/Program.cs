using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] rawInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            foreach (var item in rawInput)
            {

                Console.WriteLine($"{item} => {Math.Round(item, MidpointRounding.AwayFromZero)}");
                
            }
        }
    }
}
