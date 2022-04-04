using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            short ceturies = short.Parse(Console.ReadLine());
            int years = (int)ceturies * 100;
            int days = (int)(years * 365.2422);
            long hours = (long)days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{ceturies} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
