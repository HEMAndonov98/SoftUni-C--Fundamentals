using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!gradeBook.ContainsKey(studentName))
                {
                    gradeBook[studentName] = new List<double>();
                }
                gradeBook[studentName].Add(grade);
            }

            gradeBook = gradeBook.Where(g => g.Value.Average() >= 4.50).ToDictionary(gb => gb.Key, gb => gb.Value);

            

            foreach (var kvp in gradeBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }

        }
    }
}
