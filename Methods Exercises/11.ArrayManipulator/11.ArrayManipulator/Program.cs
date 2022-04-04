using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[] { 1, 2, 3, 4, 5, 6, 7 ,8 };
            int index = 3;

            int[] newArr = new int[intArr.Length];

            Exchange(intArr, index,out newArr);

            Console.WriteLine(string.Join(' ', newArr));

        }

        static int[] Exchange(int[] intArr, int index, out int[] newArr)
        {
            int[] newArr1 = new int[intArr.Length - (index + 1)];
            int[] newArr2 = new int[intArr.Length - index];

            newArr = new int[intArr.Length];


            Array.Copy(intArr, index + 1, newArr1, 0, newArr1.Length);
            Array.Copy(intArr, 0, newArr2, 0, index + 1);

            Array.Copy(newArr1, 0, newArr, 0, newArr1.Length);
            Array.Copy(newArr2, 0, newArr, index, newArr2.Length);

            return newArr;
        }

    }
}
