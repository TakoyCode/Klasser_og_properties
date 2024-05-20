using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_og_properties
{
    internal class Pokemon
    {
        public int Level { get; set; }
        public int Health { get; set; }
        public string Name { get; set; }

        public Pokemon()
        {
        }

        public Pokemon(int level, int health, string name)
        {
            Name = name;
            Level = level;
            Health = health;
        }

        public void showInfo()
        {
            Console.WriteLine($"{Name} har {Health}hp og er level {Level}");
        }

    }
}
