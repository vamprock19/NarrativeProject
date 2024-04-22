using System;
namespace NarrativeProject.Doors
{
    internal class Door4 : Door
    {
        

        internal override string DoorDescription() =>
@"DOOR 4
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
                    GamePlay.Print("Right door", 10);
                    GamePlay.Transition<Door4>();

                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
    }
}
