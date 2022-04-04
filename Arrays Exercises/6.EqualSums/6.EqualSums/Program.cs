using System;
using System.Linq;

namespace _6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {

//            Create a program that determines if an element exists in an array for which the sum of all elements to its left is
//equal to the sum of all elements to its right.If there are no elements to the left or right, their sum is considered to
//be 0.Print the index of the element that satisfies the condition or "no" if there is no such element.

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            bool isFound = false;
            //Here I select the element on which I will test the condition.
            for (int j = 0; j < input.Length; j++)
            {

                int leftSum = 0;
                int rightSum = 0;

                //Here I sum all the elements to the left of the selected element
                for (int k = 0; k < j; k++)
                {
                    leftSum += input[k];
                }

                //Here I run a loop backwards summing all the elements to the right of the selected el.
                for (int l = input.Length - 1;  l > j;  l--)
                {
                    rightSum += input[l];
                }

                //Test if the condition for the selected el is true
                if (leftSum == rightSum)
                {
                    Console.WriteLine(j); //print index of the selected el
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no"); //case where no such element exists.
            }
        }
    }
}
