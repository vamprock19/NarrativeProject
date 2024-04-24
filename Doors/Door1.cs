using System;
namespace NarrativeProject.Doors
{
    internal class Door1 : Door 
    {
        
        internal override string DoorDescription() =>
@" ////DOOR1////

  [HALL ROOM] [HUD]";
        
        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            int playerHealth = 0;
            switch (choice)
            {
                case "hall room":
                    GamePlay.Transition<HallRoom>();
                    break;

                case "hud":
                    Console.WriteLine(playerHealth);
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
