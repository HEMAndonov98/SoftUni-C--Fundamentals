using System;

namespace _7.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isExplosion = false;
            int explosionStrength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    isExplosion = true;
                    explosionStrength += (int)char.GetNumericValue(input[i + 1]);
                    continue;
                }

                if (isExplosion)
                {
                    if (explosionStrength != 0)
                    {
                        input = input.Remove(i, 1);
                        explosionStrength--;
                        i--;
                    }
                    else
                    {
                        isExplosion = false;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
