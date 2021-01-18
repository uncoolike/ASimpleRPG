using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASimpleRPGLibrary;

namespace ASimpleRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior Madigan = new Warrior("Madigan", 3, 15);

            Bandit Sebastian = new Bandit("Sebastian", 1, 5);
            Bandit Clyde = new Bandit("Clyde", 2, 8);

            Knight Leeroy = new Knight("Leeroy Jenkins", 3, 12);
            Knight Seth = new Knight("Seth McFarlane", 5, 15);

            Dragon BlackDrag = new Dragon("Black Dragon", 7, 20, 2);
            Dragon RedDrag = new Dragon("Red Dragon", 8, 20, 3);
            Dragon GoldDrag = new Dragon("Gold Dragon", 10, 25, 4);

            Story.BeforeBandits();
            Battle.WithBandit(Madigan, Sebastian);
            Battle.WithBandit(Madigan, Clyde);

            Madigan.LevelUp();

            Story.BeforeKnights();
            Battle.WithKnight(Madigan, Leeroy);
            Battle.WithKnight(Madigan, Seth);

            Madigan.LevelUp();

            Story.BeforeDragons();
            Battle.WithDragon(Madigan, BlackDrag);
            Battle.WithDragon(Madigan, RedDrag);
            Battle.WithDragon(Madigan, GoldDrag);

            Story.TheEnd();
        }
    }
}
