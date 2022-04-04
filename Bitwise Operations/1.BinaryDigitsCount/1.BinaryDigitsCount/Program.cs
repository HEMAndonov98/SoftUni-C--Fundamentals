using System;

namespace _1.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2);

            int numOfBCount = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == b)
                {
                    numOfBCount++;
                }
            }

            Console.WriteLine(numOfBCount);
        }
    }
}
