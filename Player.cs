using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarrativeProject
{
    internal class Player
    {
        private int defaulHealth = 100;
        public int Health
        {
            get => defaulHealth;
            set
            {
                defaulHealth = value;
                if (defaulHealth < 0)
                {
                    defaulHealth = 0;
                }
            }
        }
      


    }
}
