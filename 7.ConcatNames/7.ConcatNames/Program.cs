using System;

namespace _7.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{input1}{delimiter}{input2}");
        }
    }
}
