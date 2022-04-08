using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.MixedUpLists
{
    //    Write a program that mixes up two lists by some rules.You will receive two lines of input, each one being a list of
    //numbers.The mixing rules are:
    
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

            List<int> result = FillResultList(firstLi, secondLi);

            int minCondition = 0;
            int maxCondition = 0;
            int listLength = 0;

            if (firstLi.Count > secondLi.Count)
            {
                listLength = firstLi.Count;

                minCondition = Math.Min(firstLi[listLength - 2], firstLi[listLength - 1]);
                maxCondition = Math.Max(firstLi[listLength - 2], firstLi[listLength - 1]);

                result = result.FindAll(e => e > minCondition && e < maxCondition);
            }
            else if (secondLi.Count > firstLi.Count)
            {
                listLength = secondLi.Count;
                minCondition = Math.Min(secondLi[listLength - 2], secondLi[listLength - 1]);
                maxCondition = Math.Max(secondLi[listLength - 2], secondLi[listLength - 1]);

                result = result.FindAll(e => e > minCondition && e < maxCondition);
            }
            result.Sort();
            Console.WriteLine(string.Join(' ', result));
        }
        static List<int> FillResultList(List<int> firstLi, List<int> secondLi)
        {
            List<int> result = new List<int>();
            int smallerList = Math.Min(firstLi.Count, secondLi.Count);
            secondLi.Reverse();

            for (int i = 0; i < smallerList; i++)
            {
                result.Add(firstLi[i]);
                result.Add(secondLi[i]);
            }

            return result;
        }
    }
}
