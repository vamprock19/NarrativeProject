using System;
namespace NarrativeProject.Doors
{
     
    internal class Phone : Door
    {
        internal override string DoorDescription() =>
 @"
1 [Call 911]  2 [let's open the door to see what happens] 3[lobby]";
        internal override void DoorChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    GamePlay.Print("No answer", 10);
                    break;

                case "2":
                    if(!Lobby.key)
                    {
                        Console.WriteLine(" the door is locked");
                    }
                    else
                    {
                        GamePlay.Print("You open the door with the key you picked up",10);
                        GamePlay.Print("there is a total of 5 players including you, " +
                       "you have a maximum health of 100 HP, if health drops to 0 is Game Over. " +
                       "You have to scape through taking desitions on each door which leads " +
                       "to you being alive or dead :). You can sacrifice one of the players " +
                       "to avoid being killed but each sacrifice costs you -30 health points of your current HP. " +
                       "GOOD LUCK",10);
                        GamePlay.Transition<Door1>();

                    }
                    GamePlay.Print("door locked",10);
                    break;

                case "3":
                    GamePlay.Transition<Lobby>();
                    break;

                default:
                    Console.WriteLine("Invalid Command",10);
                    break;
            }
        }

    }
}