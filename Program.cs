using NarrativeProject.Doors;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var gamePlay = new GamePlay();
            

            gamePlay.Add(new Lobby());
            gamePlay.Add(new Phone());
            gamePlay.Add(new Door1());
            gamePlay.Add(new Door2());
            gamePlay.Add(new Door3());
            gamePlay.Add(new Door4());
            gamePlay.Add(new BonusHp());
            gamePlay.Add(new Door5());
            gamePlay.Add(new Door6());

           
           

            while(!gamePlay.isGameOver())
            {
                GamePlay.printHud();
                Console.WriteLine();    
                Console.ForegroundColor = ConsoleColor.Green;
                GamePlay.Print(gamePlay.CurrentDoorDescription);///
                Console.ForegroundColor = ConsoleColor.Red;
                string Choice = Console.ReadLine().ToLower() ?? "";///
                Console.ResetColor();
                Console.Clear();///
                gamePlay.DoorChoice(Choice);///
               
            }
            GamePlay.Print("You survive. This is the end, for now ",20);
            Console.ReadLine();
        }
       
    }
}
