namespace _5.DragonArmy
{
    public class Dragon
    {
        public Dragon(string name, string damage, string health, string armor)
        {
            this.Name = name;
            this.Damage = SetDamage(damage);
            this.Health = SetHealth(health);
            this.Armor = SetArmor(armor);
        }


        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        private int SetDamage(string damage)
        {
            if (damage == "null")
            {
                return 45;
            }

            return int.Parse(damage);
        }
        private int SetHealth(string health)
        {
            if (health == "null")
            {
                return 250;
            }
            return int.Parse(health);
        }
        private int SetArmor(string armor)
        {
            if (armor == "null")
            {
                return 10;
            }
            return int.Parse(armor);
        }
        public void ChangeStats(string damage, string health, string armor)
        {
            this.Damage = SetDamage(damage);
            this.Health = SetHealth(health);
            this.Armor = SetArmor(armor);
        }
        public override string ToString()
        {
            return $"-{this.Name} -> damage: {this.Damage}, health: {this.Health}, armor: {this.Armor}";
        }
    }
}
