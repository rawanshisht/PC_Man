using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class BronzeBox : IBox, IBronze
    {
        public int health { get; set; }
        public int weapon { get; set; }
        public void increaseHealth()
        {
            Console.WriteLine("Increase health by 20");
            health += 20;
        }

        public void increaseWeapon()
        {
            Console.WriteLine("Increase weapon by 0");
            weapon += 0;

        }
    }
}
