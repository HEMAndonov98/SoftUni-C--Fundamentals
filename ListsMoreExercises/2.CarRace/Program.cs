using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.CarRace
{
//    Write a program to calculate the winner of a car race.You will receive an array of numbers.Each element of the
//array represents the time needed to pass through that step(the index). There are going to be two cars.One of
//them starts from the left side and the other one starts from the right side.The middle index of the array is the
//finish line.The number of elements in the array will always be odd.Calculate the total time for each racer to reach
//the finish, which is the middle of the array, and print the winner with his total time (the racer with less time). If
//you have a zero in the array, you have to reduce the time of the racer that reached it by 20% (from his current
//time).
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lapTimes = new List<int>();

            lapTimes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] leftRacerTimes = lapTimes.Take(lapTimes.Count / 2).ToArray();
            int[] rightRacerTimes = lapTimes.Skip((lapTimes.Count + 1) / 2).Reverse().ToArray();

            double leftRacerTime = CalculateRacerTime(leftRacerTimes);
            double rightRacerTime = CalculateRacerTime(rightRacerTimes);

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }

        }

        static double CalculateRacerTime(int[] racerTime)
        {
            double totalTime = 0;

            for (int i = 0; i < racerTime.Length; i++)
            {
                totalTime += racerTime[i];

                if (racerTime[i] == 0)
                {
                    totalTime *= 0.8;
                }
            }

            return Math.Round(totalTime, 1);
        }
    }
}
