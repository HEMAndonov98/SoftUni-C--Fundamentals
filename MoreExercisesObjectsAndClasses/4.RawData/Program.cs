using System;
using System.Collections.Generic;

namespace _4.RawData
{
//    You are the owner of a courier company and you want to make a system for tracking your cars and their cargo.
//Define a class Car that holds a piece of information about the model, engine, and cargo.The Engine and Cargo
//    should be separate classes.Create a constructor that receives all of the information about the Car and creates and
//initializes its inner components (engine and cargo).
//On the first line of input, you will receive a number N – the number of cars you have.On each of the next N lines,
//you will receive the following information about a car: Model EngineSpeed EnginePower CargoWeight CargoType, where the speed, power and weight are all integers.
//After the N lines, you will receive a single line with one of 2 commands: &quot; fragile&quot; or &quot;flamable&quot;. If the
//command is &quot;fragile&quot; print all cars, whose Cargo Type is &quot;fragile&quot; with cargo, whose weight < 1000. If
//the command is &quot;flamable&quot; print all of the cars whose Cargo Type is &quot;flamable&quot; and has Engine Power >
//250. The cars should be printed in order of appearing in the input.
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> couriers = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);
                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                Car newCar = new Car(model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType);

                couriers.Add(newCar);
            }

            string outputCommand = Console.ReadLine();

            if (outputCommand == "fragile")
            {
               couriers = couriers.FindAll(c => c.Cargo.Type == "fragile" && c.Cargo.Weight < 1000);

                foreach (var car in couriers)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (outputCommand == "flamable")
            {
                couriers = couriers.FindAll(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250);

                foreach (var car in couriers)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
