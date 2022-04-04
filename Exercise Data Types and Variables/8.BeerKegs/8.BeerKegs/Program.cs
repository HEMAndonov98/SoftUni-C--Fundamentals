using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bestKeg = string.Empty;
            double bestKegVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                decimal kegRadius = decimal.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow((double)kegRadius, 2) * kegHeight;

                if (kegVolume > bestKegVolume)
                {
                    bestKegVolume = kegVolume;
                    bestKeg = kegModel;
                }
            }

            Console.WriteLine(bestKeg);
        }
    }
}
