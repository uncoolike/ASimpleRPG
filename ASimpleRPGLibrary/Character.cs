using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleRPGLibrary
{
    public class Character
    {
        public string name;
        public int attack;
        public int health;

        public Character(string _name, int _attack, int _health)
        {
            name = _name;
            attack = _attack;
            health = _health;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0} stats:\n", name);
            Console.WriteLine("Attack: {0}\t", attack);
            Console.WriteLine("Health: {0}", health);
        }

        public void NormAttack(Character target)
        {
            target.health -= attack;
        }
    }
}
