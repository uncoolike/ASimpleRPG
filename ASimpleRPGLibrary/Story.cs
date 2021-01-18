using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimpleRPGLibrary
{
    public class Story
    {
        public static void BeforeBandits()
        {
            Console.WriteLine("You are Madigan, a warrior who's been tasked to slay an invading army of dragons.");
            Console.WriteLine("As you are on your way to the lairs of the dragons, you run into a couple of bandits.");
            Console.WriteLine("And they don't seem to friendly...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeKnights()
        {
            Console.WriteLine("The bandits weren't much match for you. You dry your blades and continue on to the dragons lair.");
            Console.WriteLine("However, a new movement has risen that wants to protect the dragons of the world.");
            Console.WriteLine("Many people have joined this movement, including some knights.");
            Console.WriteLine("And uh oh, theres 2 of them that have found out about your quest.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeDragons()
        {
            Console.WriteLine("With the knights defeated you continue on your journey!.");
            Console.WriteLine("After a while you make it to the lair of dragons...");
            Console.WriteLine("It's hot and little smokey in there.");
            Console.WriteLine("But the time has come to end the dragons rampage!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void TheEnd()
        {
            Console.WriteLine("You killed the dragons and saved the kingdom!");
            Console.WriteLine("Congrats!");
            Console.ReadLine();
        }
    }
}
