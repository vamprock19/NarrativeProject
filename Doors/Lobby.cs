using System;
namespace NarrativeProject.Doors
{
    internal class Lobby : Door
    {
        internal static bool key;

        internal override string DoorDescription() =>
@"You just woke up.You're in some extrange place. There is no exit just a DOOR
in front of you.It is you and 4 people. in the hallway there is a desk CHOOSE! 

1 [Inspect the desk]   2 [inspect the place]  [hud]";



        internal override void DoorChoice(string choice)
        {
            Random rnd = new Random();
            var healthSystem = new HealthSystem();

            int n1 = rnd.Next(1, 50);
            int n2 = rnd.Next(1, 50);
            int n3 = rnd.Next(1, 50);
            int n4 = rnd.Next(1, 50);

            //string t1 = n1.ToString();
            //string t2 = n2.ToString();
            //string t3 = n3.ToString();
            //string t4 = n4.ToString();
            int pass = n1 + n2 + n3 + n4;






            switch (choice)
            {


                case "1":

                    GamePlay.Transition<Phone>();
                    break;

                case "2":
                    Console.WriteLine(" you go to the other side of the hallway " +
                        "and you see a note with numbers [" + n1 + n2 + n3 + n4 + "] on a piece of paper");
                    int lo = 1;

                    Console.WriteLine("type the passcode");
                    switch (lo)
                    {
                        case 1:
                            Console.WriteLine("type the passcode! Tip digit + digit + digit + digit ");
                            Console.ReadLine();
                            if (pass > 0)
                            {
                                Console.WriteLine("Something opens and you take a key ");
                                key = true;
                            }


                            break;
                    }
                    break;


                case "hud":
                    Console.WriteLine("Health " + healthSystem.Health);
                    Console.WriteLine("Change to kill " + healthSystem.kills);

                    break;

                default:
                    Console.WriteLine("Invalid Command");
                    break;
            }
        }

    }
}