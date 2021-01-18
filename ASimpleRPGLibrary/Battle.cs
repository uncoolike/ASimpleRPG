using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleRPGLibrary
{
    public class Battle
    {
        public static void IsHeroDead(Warrior warrior)
        {
            if (warrior.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("You have been slain...\nBut a warriors spirit never dies!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Character character1, Character character2)
        {
            character1.PrintStats();
            Console.WriteLine();
            character2.PrintStats();
            Console.WriteLine();
        }

        public static void WithBandit(Warrior warrior, Bandit bandit)
        {
            while (bandit.health > 0 && warrior.health > 0)
            {
                PrintTheStats(bandit, warrior);

                warrior.YourTurn(warrior.Menu(), bandit);

                if (bandit.health > 0)
                {
                    bandit.BanditTurn(bandit.EChoice(), warrior);
                    IsHeroDead(warrior);
                }

            }

            Console.WriteLine("{0} was slain!", bandit.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Warrior warrior, Knight knight)
        {
            while (knight.health > 0 && warrior.health > 0)
            {
                PrintTheStats(knight, warrior);

                warrior.YourTurn(warrior.Menu(), knight);

                if (knight.health > 0)
                {
                    knight.KnightTurn(knight.EChoice(), warrior);
                    IsHeroDead(warrior);
                }
            }

            Console.WriteLine("{0} was slain!", knight.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Warrior warrior, Dragon dragon)
        {
            while (dragon.health > 0 && warrior.health > 0)
            {
                PrintTheStats(dragon, warrior);

                warrior.YourTurn(warrior.Menu(), dragon);

                if (dragon.health > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), warrior);
                    IsHeroDead(warrior);
                }
            }

            Console.WriteLine("{0} was killed !", dragon.name);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
