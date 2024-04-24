using System;
namespace NarrativeProject.Doors
{
    internal class Door3 : Door
    {
        internal override string DoorDescription() =>
@"DOOR 3
There are 2 doors
1 [ALIVE] 2 [DEAD] ";
        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            switch (choice)
            {
                case "1":
                    GamePlay.Print("Wrong door", 10);
                    GamePlay.GameOver();
                    break;

                case "2":
                    GamePlay.Print("Right door", 10);
                    GamePlay.Transition<Door4>();
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