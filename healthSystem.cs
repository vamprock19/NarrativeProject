using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject
{
     class HealthSystem
    {
        public int defaulHealth = 100;
        public int defaultPlayers = 4;
        public int defaultKills = 4;
        
        public int Health
        {
            get => defaulHealth;
            set
            {
                defaulHealth = value;
                if (defaulHealth < 0)
                {
                    defaulHealth = 0;
                }
            }
        }
        public int Players
        {
            get => defaultPlayers;
            set
            {
                defaultPlayers= value;
                if (defaultPlayers < 0)
                {
                    defaultPlayers = 0;
                }
            }
        }
        public int kills
        {
            get => defaultKills;
            set
            {
                defaultKills = value;
                if(defaultKills < 0)
                {
                    defaultKills = -0;
                }
            }
        }

        
        //internal static void printHud()
        //{
        //    HealthSystem.PlayerHud();
        //}
        //internal  static void PlayerHud()
        //{
        //    int currentHealthValue = 100;
        //    int currentSacrificeNum = 4;
        //    int sacrifice = currentHealthValue - 30;

        //    HealthSystem.playerHealth(currentHealthValue);

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("                                         Health: " + "          [" + currentHealthValue + "]");
        //    Console.WriteLine("                                         Sacrifices: " + "      [" + currentSacrificeNum + "]");
            
        //    ;
        //}
        //internal static int playerHealth(int health)
        //{

        //    health = 100;
        //    return health;
        //}
        //internal int playerSacrifice(int sacrifice)
        //{
        //    sacrifice = 4;
        //    return sacrifice;
        //}
        //internal int playerSacrificePlayer(int sacrificePlayer)
        //{
        //    sacrificePlayer = 30;
        //    return sacrificePlayer;
        //}



    }
}
