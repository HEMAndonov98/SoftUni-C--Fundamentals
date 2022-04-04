using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numOfPeople = byte.Parse(Console.ReadLine());
            byte elevatorCapacity = byte.Parse(Console.ReadLine());

            byte numCourses = (byte)Math.Ceiling((double)numOfPeople / elevatorCapacity);

            
            Console.WriteLine(numCourses);
        }
    }
}
