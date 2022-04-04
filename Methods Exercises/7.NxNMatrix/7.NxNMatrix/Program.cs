using System;

namespace _7.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            NumberMatrix(n);
        }

        static void NumberMatrix(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[matrix.Length];

                for (int j = 0; j < matrix.Length; j++)
                {
                    matrix[i][j] = n;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
        }
    }
}
