using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());// N
            double halfPokePower = pokePower / 2.0;
            int distanceToTarget = int.Parse(Console.ReadLine());// M
            sbyte exhaustionFactor = sbyte.Parse(Console.ReadLine());// Y
            int timesPoked = 0;

            while (pokePower >= distanceToTarget)
            {
                pokePower -= distanceToTarget;
                timesPoked++;

                if (pokePower == halfPokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine($"{pokePower} \n{timesPoked}");
        }
    }
}
