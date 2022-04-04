using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLi = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondLi = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mergedLi = new List<int>();

            int minLength = Math.Min(firstLi.Count, secondLi.Count);

            for (int i = 0; i < minLength; i++)
            {
                mergedLi.Add(firstLi[i]);
                mergedLi.Add(secondLi[i]);
            }

            if (firstLi.Count > secondLi.Count)
            {
                mergedLi.AddRange(GetRemainingNumbers(firstLi, secondLi));
            }
            else if (secondLi.Count > firstLi.Count)
            {
                mergedLi.AddRange(GetRemainingNumbers(secondLi, firstLi));
            }

            Console.WriteLine(string.Join(' ', mergedLi));
        }

        static List<int> GetRemainingNumbers(List<int> LongerList, List<int> ShorterList)
        {

            List<int> remainingNums = new List<int>();

            for (int i = ShorterList.Count; i < LongerList.Count; i++)
            {
                remainingNums.Add(LongerList[i]);
            }

            return remainingNums;
        }
    }
}
