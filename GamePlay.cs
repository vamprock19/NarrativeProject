﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject
{
    internal class GamePlay
    {
        // VARIABLES
        internal bool isGameOver() => isFinished;
        static bool isFinished;
        static string nextDoor = "";
        // CLASS 
        Door currentDoor;
        // LIST
        List<Door> doors  = new List<Door>();
       
        
        internal string CurrentDoorDescription => currentDoor.DoorDescription();
        internal void Add(Door door)
        {
            doors.Add(door);
            if(currentDoor == null)
            {
                currentDoor = door;
            }
        }
        internal void DoorChoice(string choice)
        {
            currentDoor.DoorChoice(choice);
            TransitionCheck();

        }
        internal static void Transition<T>() where T : Door
        {
            nextDoor = typeof(T).Name;
        }
        internal  void TransitionCheck()
        {
            foreach(var door in doors)
            {
                if(door.GetType().Name == nextDoor)
                {
                    nextDoor = "";
                    currentDoor = door;
                    break;
                }
            }
        }
        internal static void GameOver()
        {
            isFinished = true;
        }
        
    }
}
