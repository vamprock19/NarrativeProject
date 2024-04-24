using System;
namespace NarrativeProject.Doors
{
    internal class BonusHp : Door
    {
        internal override string DoorDescription() =>
@" BONUS TIME. answer correctly to gain +HP
 How is much is 2 + 2 x 2 = ?
1 [10]  2 [8]  3[6].
";
        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            switch (choice)
            {

                case "1":
                    GamePlay.Print("Wrong. No bonus for you :)", 10);
                    GamePlay.Transition<Door5>();
                    break;

                case "2":
                    GamePlay.Print("Wrong. No bonus for you :)", 10);
                    GamePlay.Transition<Door5>();
                    break;

                case "3":
                    GamePlay.Print("Correct", 10);
                    healthSystem.Health = healthSystem.Health + 20;
                    Console.WriteLine();
                    Console.WriteLine(healthSystem.Health);
                    Console.WriteLine(healthSystem.kills);
                    Console.WriteLine(healthSystem.Players);
                    Console.ReadLine();
                    GamePlay.Transition<Door6>();
                    break;



                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }



    }
}