using System;
namespace NarrativeProject.Doors
{
    internal  class Lobby : Door
    {
        internal static bool key;
        internal override string DoorDescription() => 
@"You just woke up.You're in some extrange place. There is no exit just a DOOR
in front of you.It is you and 4 people. in the hallway there is a desk CHOOSE! 

1 [Inspect the desk]   2 [inspect the place] 3 [inspect the sheet of paper on the floor] [****] [hud]";



        internal override void DoorChoice(string choice)
        {
            
            var healthSystem = new HealthSystem();
          switch(choice)
          {
                
                case "1":
                    
                    GamePlay.Transition<Phone>();
                    break;

                case "2":
                    Console.WriteLine(" you go to the other side of the hallway " +
                        "and you see a note with numbers [12] ");
                    break;

                case "3":
                    Console.WriteLine("you see the numbers [34] on a poster");
                    break;


                case "1234":
                    Console.WriteLine("Something opens and you get a key");
                    key = true;
                    Console.ReadLine();
                    break;


                case "hud":
                    Console.WriteLine(healthSystem.Health);
                    Console.WriteLine(healthSystem.kills);
                    Console.WriteLine(healthSystem.Players);
                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
          }
        }
        
    }
}
