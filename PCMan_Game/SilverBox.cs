using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class SilverBox : IBox, ISilver
    {
        public int health { get; set; }
        public int weapon { get; set; }
        public void increaseHealth()
        {
            Console.WriteLine("Increase health by 40");
            health += 40;
        }

        public void increaseWeapon()
        {
            Console.WriteLine("Increase weapon by 10");
            weapon += 10;

        }
    }
}