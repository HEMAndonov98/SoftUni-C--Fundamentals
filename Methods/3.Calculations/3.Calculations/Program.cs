using System;

namespace _3.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                AddNumbers(firstNum, secondNum);
            }
            else if (operation == "multiply")
            {
                MultiplyNumbers(firstNum, secondNum);
            }
            else if (operation == "subtract")
            {
                SubtractNumbers(firstNum, secondNum);
            }
            else if (operation == "divide")
            {
                DivideNumbers(firstNum, secondNum);
            }
        }

        static void AddNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum + secondNum}");
        }

        static void MultiplyNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum * secondNum}");
        }

        static void SubtractNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum - secondNum}");
        }

        static void DivideNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine($"{firstNum / secondNum}");
        }
    }
}
