﻿using System;

namespace _2.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            GetGrade(grade);
        }

        static void GetGrade(double grade)
        {
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 3.00)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
