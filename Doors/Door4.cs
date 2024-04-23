using System;
namespace NarrativeProject.Doors
{
    internal class Door4 : Door
    {
        

        internal override string DoorDescription() =>
@"DOOR 4
There are 2 doors. Why there is a key?
1 [ALIVE] 2 [DEAD]   3 [Pick up key]";
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
                case "3":
                    Console.WriteLine("You collected the key");
                    key = true;
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }
    }
}
