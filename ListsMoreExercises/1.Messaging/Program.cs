using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Messaging
{
//    You will be given a list of numbers and a string. For each element of the list, you must calculate the sum of its digits
//and take the element, corresponding to that index from the text.If the index is greater than the length of the text,
//start counting from the beginning(so that you always have a valid index). After you get that element from the text,
//you must remove the character you have taken from it(so for the next index, the text will be with one
//characterless).

    class Program
    {
        static void Main(string[] args)
        {
            List<char[]> numbers = new List<char[]>();

            string[] inputNum = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var sequence in inputNum)
            {
                numbers.Add(sequence.ToCharArray());
            }

            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();


            foreach (var sequenceofNums in numbers)
            {
                int sumOfDigits = sequenceofNums.Sum(x => int.Parse(x.ToString()));
                int index = sumOfDigits % message.Length;
                sb.Append(message[index]);
                message = message.Remove(index, 1);
            }

            Console.WriteLine(sb);
        }
    }
}
