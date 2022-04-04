using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.VihicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }


        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalog
    {
        public Catalog()
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            this.Trucks = trucks;
            this.Cars = cars;
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

        

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string rawInput;

            while ((rawInput = Console.ReadLine()) != "end")
            {
                string[] tokens = rawInput.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int horsePowerOrWeight = int.Parse(tokens[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, horsePowerOrWeight);
                    catalog.Cars.Add(newCar);
                }
                else if (type == "Truck")
                {
                    Truck newTruck = new Truck(brand, model, horsePowerOrWeight);
                    catalog.Trucks.Add(newTruck);
                }
            }

            List<Car> orderedCarsList = catalog.Cars.OrderBy(car => car.Brand).ToList();
            List<Truck> orderedTrucksList = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

            if (catalog.Cars.Count == 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucksList)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            else if (catalog.Trucks.Count == 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCarsList)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            else
            {
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCarsList)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucksList)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
