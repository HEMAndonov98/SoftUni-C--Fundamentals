using System;
using System.Collections.Generic;

namespace _6.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] courseArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = courseArgs[0];
                string studentName = courseArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);
            }

            PrintCoursesInfo(courses);
        }

        static void PrintCoursesInfo(Dictionary<string, List<string>> courses)
        {
            foreach (var kvp in courses)
            {
                int numberOfStudents = kvp.Value.Count;
                Console.WriteLine($"{kvp.Key}: {numberOfStudents}");

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
