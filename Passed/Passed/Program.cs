using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEvenNumber = false;
            int input = int.Parse(Console.ReadLine());

            do
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {input}");
                    isEvenNumber = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                input = int.Parse(Console.ReadLine());
            } while (isEvenNumber == false);
        }
    }
}
