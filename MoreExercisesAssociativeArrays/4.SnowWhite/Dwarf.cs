using System;
namespace _4.SnowWhite
{
    public class Dwarf
    {
        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.HatColor = color;
            this.Physics = physics;
        }

        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physics { get; set; }
    }
}
