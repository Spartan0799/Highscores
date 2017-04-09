using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highscores
{
    class Program
    {

        public class Clans
        {
            public string clan;
            public int score;

            public Clans(string clan, int score)
            {
                this.clan = clan;
                this.score = score;
            }
        }


        static void Main(string[] args)
        {

            Clans clan1 = new Clans("SK", 618);
            Clans clan2 = new Clans("NiP", 224);
            Clans clan3 = new Clans("Fnatic", 237);
            Clans clan4 = new Clans("Immortals", 343);
            Clans clan5 = new Clans("G2", 133);
            Clans clan6 = new Clans("Astralis", 1000);
            Clans clan7 = new Clans("Faze Clan", 523);
            Clans clan8 = new Clans("Virtus.pro", 757);
            Clans clan9 = new Clans("Natus Vincere", 422);
            Clans clan10 = new Clans("North", 476);

            Clans[] clans = { clan1, clan2, clan3, clan4, clan5, clan6, clan7, clan8, clan9, clan10};

            Clans clanIndex;

            for (int i = 0; i < clans.Length; i++)
            {
                for (int j = 0; j < clans.Length - 1; j++)
                {
                    if (clans[j].score > clans[j + 1].score)
                    {
                        clanIndex = clans[j];
                        clans[j] = clans[j + 1];
                        clans[j + 1] = clanIndex;
                    }
                }
            }


            for (int i = clans.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(clans[i].clan + "(" + clans[i].score + " points" + ")");
            }
            Console.WriteLine();

            Console.WriteLine("Type the clan name that you wanna add to the list");
            string NewClanName = Console.ReadLine();
            Console.WriteLine("Type his score");
            int NewClanScore = int.Parse(Console.ReadLine());
            Clans NewClan = new Clans(NewClanName, NewClanScore);
            Clans[] newClan = { NewClan };

            for (int i = 0; i < clans.Length; i++)
            {
                if (NewClanScore > clans[i].score)
                {
                    clanIndex = clans[i];
                    clans[i] = NewClan;
                    if (i != 0)
                    {
                        clans[i - 1] = clanIndex;
                    }
                }
            }

            Console.Clear();

            for (int i = clans.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(clans[i].clan + "(" + clans[i].score + " points" + ")");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
