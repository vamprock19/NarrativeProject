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
                       "you have a maximum health of 100 HP, if health drops to 0 is Game Over. " +
                       "You have to scape through taking desitions on each door which leads " +
                       "to you being alive or dead :). You can sacrifice one of the players " +
                       "to avoid being killed but each sacrifice costs you -30 health points of your current HP. " +
                       "GOOD LUCK");
                        GamePlay.Transition<Door1>();
                        Console.WriteLine("there is a total of 5 players including you, " +
                        Console.WriteLine("You open the door with the key you picked up");

                    }
                    break;

                case "lobby":
                    GamePlay.Transition<Lobby>();
                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

    }
}