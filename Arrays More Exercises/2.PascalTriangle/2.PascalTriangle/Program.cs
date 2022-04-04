using System;
using System.Linq;

namespace _2.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[lines][];

            for (int row = 0; row < lines; row++)
            {
                jaggedArray[row] = new long[row + 1];//Here I initialize the length of the array

                jaggedArray[row][0] = 1;
                jaggedArray[row][^1] = 1;

                for (int col = 1; col < row; col++)
                {
                    jaggedArray[row][col] = jaggedArray[row - 1][col - 1] + jaggedArray[row - 1][col];
                }
            }

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine(string.Join(' ', jaggedArray[i]));
            }
        }
    }
}
