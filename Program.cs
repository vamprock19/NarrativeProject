using NarrativeProject.Rooms;
using System;

namespace NarrativeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // constructor
            // YHEP 
            var game = new Game();
            

            /* if you want to start from a different position
             * just move the variable to the top (initial value)*/

            game.Add(new Bedroom());
            game.Add(new Bathroom());
            game.Add(new AtticRoom());
            // new Rooms
            game.Add(new LivingRoom());
            

            while (!game.IsGameOver())
            {
                Console.WriteLine("--");
                Console.WriteLine(game.CurrentRoomDescription);
                string choice = Console.ReadLine().ToLower() ?? "";
                Console.Clear();
                game.ReceiveChoice(choice);
            }

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
