using System;

namespace _8.TownInfor
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short squareKilometeres = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {squareKilometeres} square km.");
        }
    }
}
