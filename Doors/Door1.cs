﻿using System;
namespace NarrativeProject.Doors
{
    internal class Door1 : Door
    {

        internal override string DoorDescription() =>
@" DOOR 1
There are 2 doors
1 [ALIVE] 2 [DEAD]   [hud]";

        internal override void DoorChoice(string choice)
        {
            var healthSystem = new HealthSystem();
            int playerHealth = 0;
            switch (choice)
            {
                case "1":
                    GamePlay.Print("Wrong door. luckly one of the other " +
                        "players entered the door and " +
                        "received a laser headshot", 10);

                    if (choice == "1")
                    {
                        healthSystem.defaulHealth -= 15;

                        Console.WriteLine(healthSystem.defaulHealth);

                    }


                    GamePlay.Transition<Door2>();
                    break;

                case "2":
                    GamePlay.Print("Right door", 10);
                    GamePlay.Transition<Door2>();
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