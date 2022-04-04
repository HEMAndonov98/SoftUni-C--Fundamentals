using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalLiteresPoured = 0;
            int tankCapacity = 255;


            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if (tankCapacity - litersToPour < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankCapacity -= litersToPour;
                    totalLiteresPoured += litersToPour;
                }
            }
            Console.WriteLine(totalLiteresPoured);
        }
    }
}
