using System;
namespace NarrativeProject.Doors
{
    internal  class Lobby : Door
    {
        
        internal override string DoorDescription() => 
@"You just woke up.You're in some extrange place. There is no exit just a DOOR
in front of you.It is you and 4 people. in the hallway there is a desk CHOOSE! 

1 [Inspect the desk]   2 [Let's beggin]";
        internal override void DoorChoice(string choice)
        {
            
          switch(choice)
          {
                
                case "1":
                    Console.WriteLine(" you see a phone");
                    Console.ReadLine();
                    GamePlay.Transition<Phone>();
                    break;

                case "2":
                    Console.WriteLine("Game on");
                    Console.WriteLine("there is a total of 5 players including you," +
                        "you have a maximum health of 100 HP, if health drops to 0 is Game Over." +
                        "you have to scape through taking desitions on each door which leads" +
                        "to you being alive or dead :). You can sacrifice one of the players" +
                        "to avoid being killed but each sacrifice costs you -30 health points of your current HP." +
                        "GOOD LUCK");
                    Console.ReadLine();
                    GamePlay.Transition<Door1>();
                    break;

                case "HUD":
                    GamePlay.HUD();
                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
          }
        }
        
    }
}
