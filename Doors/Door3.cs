using System;
namespace NarrativeProject.Doors
{
    internal class Door3 : Door
    {
        internal override string DoorDescription() =>
@"DOOR 3

[HAL ROOM] [HUD] ";
        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            switch (choice)
            {
                case "hall room":
                    GamePlay.Transition<HallRoom>();
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
