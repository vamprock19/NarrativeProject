using System;
namespace NarrativeProject.Doors
{
    internal class Door1 : Door 
    {
        internal override string DoorDescription() =>
@" DOOR 1
There are 2 doors
1 [ALIVE] 2 [DEAD]";
        
        internal override void DoorChoice(string choice)
        {
            
            switch (choice)
            {
                case "1":
                    GamePlay.Print("Wrong door. luckly one of the other" +
                        "players was the one who enter the door and" +
                        "received a laser head shot", 10);
                    
                    GamePlay.printHud();
                    
                    GamePlay.Transition<Door2>();
                    break;
                case "2":
                    GamePlay.Print("Right door", 10);
                    GamePlay.Transition<Door2>();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
            

        }
        internal override void Hud()
        {
            
        }
    }
}
