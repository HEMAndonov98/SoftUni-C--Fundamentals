using System;
namespace _4.RawData
{
    public class Car
    {
        public Car(string model,
           int engineSpeed,
           int enginePower,
           int cargoWeight,
           string cargoType)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
    }
}
