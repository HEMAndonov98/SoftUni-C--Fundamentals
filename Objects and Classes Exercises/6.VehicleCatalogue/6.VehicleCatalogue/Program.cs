using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.VehicleCatalogue
{
    class Catalogue
    {
        public Catalogue(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string  Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {this.Type}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"Color: {this.Color}{Environment.NewLine}" +
                $"Horsepower: {this.Horsepower}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> vehicleCatalogue = new List<Catalogue>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vihicleArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = vihicleArgs[0];

                if (type == "car")
                {
                    type = "Car";
                }
                else if (type == "truck")
                {
                    type = "Truck";
                }

                string model = vihicleArgs[1];
                string color = vihicleArgs[2];
                int horsepower = int.Parse(vihicleArgs[3]);

                Catalogue newVihicle = new Catalogue(type, model, color, horsepower);
                vehicleCatalogue.Add(newVihicle);
            }

            string vehicleToSearch;

            while ((vehicleToSearch = Console.ReadLine()) != "Close the Catalogue")
            {
                Catalogue searchedVehicle = vehicleCatalogue.FirstOrDefault(v => v.Model == vehicleToSearch);

                Console.WriteLine(searchedVehicle);
            }

            List<Catalogue> truckCatalogue = vehicleCatalogue.Where(v => v.Type == "Truck").ToList();
            List<Catalogue> carCatalogue = vehicleCatalogue.Where(v => v.Type == "Car").ToList();

            double carTotalHorsepower = carCatalogue.Sum(v => v.Horsepower);
            int carCount = carCatalogue.Count();

            if (carCatalogue.Count > 0)
            {

                Console.WriteLine($"Cars have average horsepower of: {carTotalHorsepower / carCount:F2}.");
            }
            else
            {

                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            double truckTotalHorsepower = truckCatalogue.Sum(v => v.Horsepower);
            int truckCount = truckCatalogue.Count();

            if (truckCatalogue.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckTotalHorsepower / truckCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");

            }
        }
    }
}
