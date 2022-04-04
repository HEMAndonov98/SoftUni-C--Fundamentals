using System;

namespace _5.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractFromSum(AddNumbers(firstNum, secondNum), thirdNum));
        }

        static int AddNumbers(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }

        static int SubtractFromSum(int sum, int thirdNum)
        {
            sum -= thirdNum;
            return sum;
        }
    }
}
