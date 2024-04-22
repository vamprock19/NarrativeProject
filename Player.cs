using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject
{
    internal class Player
    {
        private int defaulHealth = 100;
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
        internal static void printHud()
        {
            Player.PlayerHud();
        }
        internal static void PlayerHud()
        {

            var player = new Player();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                         Health: " + "[" + player.Health + "]");
        }
        enum playerDesitions
        {
            sacrifice = -30, 
            alive, 
            dead, 
            bHP = 20
        }


    }
}
