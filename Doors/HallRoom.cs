


using System;
namespace NarrativeProject.Doors
{
    internal class HallRoom: Door
    {


        internal override string DoorDescription() =>
@" HALL ROOM
 To scape you have to find the exit. Some doors are locked.
 [DOOR1]  [DOOR2] [DOOR3] [DOOR4] [HUD]";

        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            int playerHealth = 0;
            switch (choice)
            {
                case "door1":
                    //GamePlay.Print("Wrong door. luckly one of the other " +
                    //    "players entered the door and " +
                    //    "received a laser headshot", 10);

                    //if (choice == "1")
                    //{
                    //    healthSystem.defaulHealth -= 15;

                    //    Console.WriteLine(healthSystem.defaulHealth);

                    //}


                    GamePlay.Transition<Door1>();
                    break;

                case "door2":

                    GamePlay.Transition<Door2>();
                    break;

                case "door3":

                    GamePlay.Transition<Door3>();
                    break;

                case "door4":

                    GamePlay.Transition<Door4>();
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


