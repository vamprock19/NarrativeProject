using NarrativeProject.Doors;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ps1 = "";
            Print("What is your name player?", 20);
            ps1 = Console.ReadLine();
            Program.Print(GamePlay.PlayerName(ps1),10);


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
                
                Console.ForegroundColor = ConsoleColor.Green;
                Print(gamePlay.CurrentDoorDescription , 10);///
                Console.ForegroundColor = ConsoleColor.Red;
                string Choice = Console.ReadLine().ToLower() ?? "";///
                Console.ResetColor();
                Console.Clear();///
                gamePlay.DoorChoice(Choice);///
                Program.Print(GamePlay.PlayerName(ps1), 10);
            }
            Print("You survive. This is the end, for now ",20);
           
            
            
        }
        public static void Print(string text, int speed = 0)
        {
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}
