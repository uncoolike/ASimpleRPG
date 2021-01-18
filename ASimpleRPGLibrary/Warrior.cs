using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleRPGLibrary
{
    public class Warrior : Character
    {
        public int healLvl = 7, maxHealth = 15;

        public Warrior(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        public void LevelUp()
        {
            Console.WriteLine("You leveled up !\nAttack +3\tMax health + 10\nHeal +5\n\n");
            Console.ReadLine();
            Console.Clear();

            attack += 3;
            maxHealth += 10;
            health = maxHealth;
            healLvl += 5;
        }

        public void Heal()
        {
            health += healLvl;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void SpinAttack(Enemy target)
        {
            target.health -= ((attack - 2) * 3);
        }

        public void DoubleSlash(Enemy target)
        {
            target.health -= attack * 2;
        }

        public int Menu()
        {
            bool correctInput = true;
            int menuChoice = 0, menuChoice2;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?\n\n1) Attack\t2) Heal\t3) Special\n");

                bool test = int.TryParse(Console.ReadLine(), out menuChoice);
                if (!test || menuChoice > 3 || menuChoice <= 0)
                {
                    Console.WriteLine("Thats not one of the options! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (menuChoice == 3) // Specials menu
                {
                    Console.WriteLine("Choose Special:\n\n1) Spin Attack\t2) Double Slash\n4) <--- Go back\n");

                    bool test2 = int.TryParse(Console.ReadLine(), out menuChoice2);
                    if (!test2 || menuChoice2 > 3 || menuChoice2 <= 0)
                    {
                        Console.WriteLine("Thats not one of the options ! Try again!\n");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (menuChoice2 == 1)
                    {
                        menuChoice = 4;
                    }

                    if (menuChoice2 == 2)
                    {
                        menuChoice = 5;
                    }
                }

                if (menuChoice == 1 || menuChoice == 2 || menuChoice == 4 || menuChoice == 5)
                {
                    break;
                }
            }
            return menuChoice;
        }

        public void YourTurn(int decision, Enemy target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("You kicked the enemy!");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("You healed for {0} health!", healLvl);
            }

            if (decision == 4)
            {
                SpinAttack(target);
                Console.WriteLine("You used spin attack!");
            }

            if (decision == 5)
            {
                DoubleSlash(target);
                Console.WriteLine("You used double slash!");
            }
        }
    }

}