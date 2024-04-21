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

            while(!gamePlay.isGameOver())
            {
                Console.WriteLine(gamePlay.CurrentDoorDescription);
                string Choice = Console.ReadLine().ToLower() ?? "";
            }
           
            
            
        }
    }
}
