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
                    GamePlay.Transition<Phone>();
                    break;
                case "2":
                    Console.WriteLine("Game on");
                    GamePlay.Transition<Door1>();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
          }
        }
    }
}
