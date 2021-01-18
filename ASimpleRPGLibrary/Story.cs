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
            Console.WriteLine("You are Madigan, the strongest warrior in the kingdom who's been tasked to slay an invading army of dragons.\nThe dragons have killed countless citizens as well as stolen your kingdoms beloved Princess Asmeralda!\nAs you are on your way to the dragons lair, you run into a couple of bandits.\nThey approach you and exclaim that it is either time to pay up with gold or with your life, you take them up on their second option and ready your blades.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeKnights()
        {
            Console.WriteLine("The bandits were not much of a match for you. You dry your blades and continue on to the dragons lair.\nHowever before their deaths you came to the realization that these bandits may have been under some sort of mind control as they fought carelessly in battle as if they had no concern for their own lives\nYou have heard of dragons having the ability to control the minds of humans, it turns out the dragons have taken over the minds\nof some of the kingdoms finest knights, you are approached by two that you know by name, they also seem to be under the dragons spell.\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeDragons()
        {
            Console.WriteLine("With the knights defeated you continue on your journey!.\nAfter your long trek you have reached the last known location of the dragons.\nJudging by the smoke and flames you think they may be nearby.\nOverhead you hear the long high pitched shriek of an angry dragon.\nYou are correct. And now the final battle begins. Go forth warrior!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void TheEnd()
        {
            Console.WriteLine("You have slain the dragons and restored peace to the kingdom, however your princess is still in another castle, Mario! I mean warrior!");
            Console.WriteLine("*More coming soon*");
            Console.ReadLine();
        }
    }
}
