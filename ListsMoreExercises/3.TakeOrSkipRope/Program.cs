using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.TakeOrSkipRope
{
//    Write a program, which reads a string and skips through it, extracting a hidden message.The algorithm you have to
//implement is as follows:
//Let’s take the string &quot; skipTest_String044170&quot; as an example.
// Take every digit from the string and store it somewhere.After that, remove all the digits from the string. After this
// operation, you should have two lists of items: the numbers list and the non-numbers list:
// Numbers list: [0, 4, 4, 1, 7, 0]
// Non-numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
//After that, take every digit in the numbers list and split it up into a take list and a skip list, depending on whether
// the digit is in an even or an odd index:
// Numbers list: [0, 4, 4, 1, 7, 0]
// Take list: [0, 4, 7]
// Skip list: [4, 1, 0]
//Afterward, iterate over both lists and skip { skipCount}
//    characters from the non-numbers list, then take
//{takeCount
//}
//characters and store it in a result string. Note that the skipped characters are summed up as they go.
//The process would look like this on the aforementioned non-numbers list:
//1.Take 0 characters -> Taken: "", skip 4 characters(total 0) -> Skipped: "skipTest_String" -> Result: ""
//2.Take 4 characters-> Taken: Test , skip 1 character(total 4) -> Skipped: "skip" -> Result: "Test";
//3.Take 7 characters-> Taken: "", skip 0 characters(total 9) -> Skipped: "" -> Result: "TestString";
//After that, just print the result string on the console.
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> digits = input.Where(ch => char.IsDigit(ch))
                .Select(ch => int.Parse(ch.ToString()))
                .ToList();
            string pattern = "[^0-9]";

            List<char> letters = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(ch => char.Parse(ch.ToString()))
                .ToList();

            List<int> take = new List<int>();
            List<int> skip = new List<int>();

            GetTakeAndSkipList(digits, take, skip);

            int currentIndex = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < take.Count; i++)
            {
                if (currentIndex + take[i] < letters.Count)
                {
                    sb.AppendJoin(string.Empty, letters.GetRange(currentIndex, take[i]));
                }
                else
                {
                    for (int k = currentIndex; k < letters.Count; k++)
                    {
                        sb.Append(letters[k]);
                    }
                }
                currentIndex += skip[i] + take[i];

                if (currentIndex >= letters.Count)
                {
                    break;
                }
            }

            Console.WriteLine(sb);
        }

        static void GetTakeAndSkipList(List<int> digits, List<int> take, List<int> skip)
        {
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    skip.Add(digits[i]);
                }
            }
        }
    }
}
