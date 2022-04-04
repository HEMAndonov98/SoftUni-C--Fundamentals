using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Students
{
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentsArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = studentsArg[0];
                string lastName = studentsArg[1];
                double grade = double.Parse(studentsArg[2]);

                Student newstudent = new Student(firstName, lastName, grade);
                students.Add(newstudent);
            }

            List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, sortedStudents));
        }
    }
}
