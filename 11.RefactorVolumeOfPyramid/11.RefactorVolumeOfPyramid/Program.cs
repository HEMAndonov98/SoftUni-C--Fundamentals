using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtSideA = double.Parse(Console.ReadLine());
            double lengthSidaB = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double volume = (lenghtSideA * lengthSidaB * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
