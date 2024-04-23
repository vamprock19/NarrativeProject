using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject
{
    internal class GamePlay
    {
        // VARIABLES
        internal bool isGameOver() => isFinished;
        static bool isFinished;
        static string nextDoor = "";
        // CLASS 
        Door currentDoor;
        // LIST
        List<Door> doors  = new List<Door>();
        
        
        
        
       
      
        internal string CurrentDoorDescription => currentDoor.DoorDescription();
        internal void Add(Door door)
        {
            doors.Add(door);
            if(currentDoor == null)
            {
                currentDoor = door;
            }
        }
        internal void DoorChoice(string choice)
        {
            currentDoor.DoorChoice(choice);
            TransitionCheck();

        }
        internal static void Transition<T>() where T : Door
        {
            nextDoor = typeof(T).Name;
        }
        internal  void TransitionCheck()
        {
            foreach(var door in doors)
            {
                if(door.GetType().Name == nextDoor)
                {
                    nextDoor = "";
                    currentDoor = door;
                    break;
                }
            }
        }
        internal static void GameOver()
        {
            isFinished = true;
            GamePlay.Print("YOU DIED.   GAME OVER");
        }
        public static void Print(string text, int speed = 0)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }


        internal static void printHud()
        {
            GamePlay.PlayerHud();
        }
        internal static void PlayerHud()
        {
           
            //var player = new healthSystem();
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("                                         Health: " + "          [" + player.Health + "]");
            //Console.WriteLine("                                         Sacrifices: " + "      [" + (int)GamePlay.playerDesitions.sacrifices + "]");
        }
        internal int playerHealth(int health)
        {
            
            health = 100;
            
            return health;
        }
        internal int playerSacrifice(int sacrifice)
        {
            sacrifice = 4;
            return sacrifice;
        }
        internal int playerSacrificePlayer(int sacrificePlayer)
        {
            sacrificePlayer = 30;
            return sacrificePlayer;
        }
        
        

    }
   

}
