using System;
namespace NarrativeProject
{
    internal class Door5 : Door
    {
        internal override string DoorDescription() =>
@"DOOR 5
";
        
            
        
        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            switch (choice)
            {
                

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