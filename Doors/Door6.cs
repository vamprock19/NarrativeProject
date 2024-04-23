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
            var healthSystem = new HealthSystem();
            switch (choice)
            {
                case "1":
                    GamePlay.Print("Wrong door", 10);
                    GamePlay.GameOver();
                    Console.WriteLine();
                    break;

                case "2":
                    GamePlay.Print("Right door", 10);
                    GamePlay.GameFinished();
                    GamePlay.HUD();
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
    }
}