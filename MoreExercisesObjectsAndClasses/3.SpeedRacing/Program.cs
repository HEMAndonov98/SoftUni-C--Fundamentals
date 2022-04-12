using System;
using System.Collections.Generic;

namespace _3.SpeedRacing
{
//    Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the
//cars.Define a class Car that keeps a track of a car’s model, fuel amount, fuel consumption per
//kilometer, and traveled distance.A Car’s model is unique - there will never be 2 cars with the same model.
//On the first line of the input, you will receive a number N – the number of cars you need to track. On each of the
//next N lines you will receive information about cars in the following format &quot;&lt;Model&gt; &lt;FuelAmount&gt;
//&lt;FuelConsumptionFor1km&gt;&quot;. All cars start at 0 kilometers traveled.
//After the N lines, until the command &quot; End&quot; is received, you will receive commands in the following format &quot;Drive
//&lt;CarModel&gt; &lt;amountOfKm&gt;&quot;. Implement a method in the Car class to calculate whether or not a car can move
//that distance.If it can, the car’s fuel amount should be reduced by the amount of used fuel and its traveled
//distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its
//fuel amount and the traveled distance should stay the same) and you should print on the console &quot;Insufficient
//fuel for the drive&quot;. After the &quot;End&quot; command is received, print each car, its current fuel amount and
//the traveled distance in the format &quot;&lt;Model&gt; &lt;fuelAmount&gt; &lt;distanceTraveled&gt;&quot;. Print the fuel
//amount rounded to two digits after the decimal separator.
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            PopulateListCars(cars, n);

            ProcessCarsInfo(cars);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
        static void PopulateListCars(List<Car> cars, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsumption = double.Parse(carArgs[2]);

                var newCar = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(newCar);
            }
        }

        static void ProcessCarsInfo(List<Car> cars)
        {
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] comandArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string selectModel = comandArgs[1];
                int distance = int.Parse(comandArgs[2]);

                var selectedCar = cars.Find(c => c.Model == selectModel);

                selectedCar.Drive(distance);
            }
        }
       
    }
}
