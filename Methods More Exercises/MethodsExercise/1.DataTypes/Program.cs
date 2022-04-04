using System;

namespace _1.DataTypes
//    Write a program that, depending on the first line of the input, reads an int, double, or string.
// If the data type is int, multiply the number by 2.
// If the data type is real, multiply the number by 1.5 and format it to the second decimal point.
// If the data type is a string, surround the input with &quot;$&quot;.
//Print the result on the console.
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();

            if (dataType == "int")
            {
                int number = int.Parse(value);
                Console.WriteLine(ProcessValue(number));
            }
            else if (dataType == "real")
            {
                double realNum = double.Parse(value);
                Console.WriteLine($"{ProcessValue(realNum):F2}");
            }
            else if (dataType == "string")
            {
                Console.WriteLine(ProcessValue(value));
            }
        }
        static int ProcessValue(int number)
        {
            return number * 2;
        }
        static double ProcessValue(double realNum)
        {
            return realNum * 1.5;
        }
        static string ProcessValue(string word)
        {
            return $"${word}$";
        }
    }
}
