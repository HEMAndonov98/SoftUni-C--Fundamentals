using System;
using System.Text;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            if (multiplier == 0 || number == string.Empty)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentNumber = (int)Char.GetNumericValue(number[i]);
                int currentMultiplication = (currentNumber * multiplier) + remainder;

                int numberToWrite = currentMultiplication % 10;
                result.Insert(0, numberToWrite);

                remainder = currentMultiplication / 10;
            }

            if (remainder > 0)
            {
                Console.WriteLine($"{remainder}{result}");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}