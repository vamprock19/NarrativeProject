using System;
namespace NarrativeProject.Doors
{
    internal class Phone : Door
    {
        internal override string DoorDescription() =>
 @"
1 [Call 911]  2 [No, let's open the door to see what happens] 3[lobby]";
        internal override void DoorChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    GamePlay.Print("No answer", 10);
                    break;
                case "2":
                    GamePlay.Print("Game on",10);
                    GamePlay.Transition<Door1>();
                    break;
                case "3":
                    GamePlay.Transition<Lobby>();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

    }
}