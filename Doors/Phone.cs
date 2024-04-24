using System;
namespace NarrativeProject.Doors
{
     
    internal class Phone : Door
    {
        internal override string DoorDescription() =>
 @"
 [CALL 911]  [OPEN THE DOOR] [LOBBY]";
        internal override void DoorChoice(string choice)
        {
            switch (choice)
            {
                case "call 911":
                    GamePlay.Print("No answer", 10);
                    break;

                case "open the door":
                    if(!Lobby.key)
                    {
                        Console.WriteLine(" the door is locked");
                    }
                    else
                    {
                        GamePlay.Print("You open the door with the key you picked up",10);
                        Console.ReadLine();
                        GamePlay.Transition<HallRoom>();
                        Console.Clear();

                    }
                    break;

                case "lobby":
                    GamePlay.Transition<Lobby>();
                    break;

                default:
                    Console.WriteLine("Invalid Command",10);
                    break;
            }
        }

    }
}