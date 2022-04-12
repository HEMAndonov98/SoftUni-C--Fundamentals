using System;
namespace _4.RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.Weight = cargoWeight;
            this.Type = cargoType;
        }

        public int Weight { get; set; }
        public string Type { get; set; }
    }
}
