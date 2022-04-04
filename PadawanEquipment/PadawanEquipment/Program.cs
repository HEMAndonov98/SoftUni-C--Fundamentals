using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int numStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double extraLightsabers = Math.Ceiling(numStudents + (numStudents * 0.1));
            int freeBelts = numStudents / 6;

            double totalPrice = lightsaberPrice * extraLightsabers + robePrice * numStudents + beltPrice * (numStudents - freeBelts);
            

            if ((money - totalPrice) >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money - totalPrice):F2}lv more.");
            }
        }
    }
}
