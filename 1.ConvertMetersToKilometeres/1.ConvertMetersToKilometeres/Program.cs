using System;

namespace _1.ConvertMetersToKilometeres
{
    class Program
    {
        static void Main(string[] args)
        {
            int meteres = int.Parse(Console.ReadLine());
            decimal kilometeres = ((decimal)meteres / 1000);
            Console.WriteLine($"{kilometeres:F2}") ;
        }
    }
}
