using System;
namespace NarrativeProject.Doors
{
    internal  class Lobby : Door
    {
        
        internal override string DoorDescription() =>
@"You just woke up.You're at the lobby. There is no exit just a DOOR
in front of you.It is you and 4 people.CHOOSE! 

1 [Inspect the lobby]   2 [Let's beggin]";
        internal override void DoorChoice(string choice)
        {
            if (choice == "1")
            {
                Console.WriteLine("kdkdkd");
            }
            else
            {
                Console.WriteLine("kdkdi9 kdid");
            }
        }
    }
}
