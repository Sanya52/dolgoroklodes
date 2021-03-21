using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatoroklodes
{
    class Weapon
    {
        public int demage;
        public string name;
        public Weapon(int d, string n)
        {
            demage = d;
            name = n;

        }

    }
    class Character
    {
        public int hp;
        public int lvl;
        public int strength;
        public int agility;
        public int endurance;
        public Weapon(int d,string n)
        {
            return Weapon;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
