using System;
namespace NarrativeProject.Doors
{
    internal class Phone : Door
    {
        internal override string DoorDescription() =>
 @"Call 911?
1 [yes]  2 [No, let's open the door to see what happens]";
        internal override void DoorChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    Program.Print("No answer", 10);
                   
                    GamePlay.Transition<Phone>();
                    break;
                case "2":
                    Program.Print("Game on",10);
                    GamePlay.Transition<Door1>();
                    break;
                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

    }
}