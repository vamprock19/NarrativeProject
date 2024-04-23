using System;
namespace NarrativeProject
{
    internal class Door6 : Door
    {
        
        internal override string DoorDescription() =>
@"DOOR 6
There are 2 doors
1 [ALIVE] 2 [DEAD]";
        
            
        
        internal override void DoorChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    GamePlay.Print("Wrong door", 10);
                    GamePlay.GameOver();
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
    }
}