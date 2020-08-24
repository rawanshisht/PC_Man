using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    public class Player

    {
        private static Player _instance;

        public int health { get; set; }
        //list of keys and treasures
        public List<IKey> keys { get; set; }

        public int xPosition { get; set; }
        public int yPosition { get; set; }


        private Player()
        {
            keys = new List<IKey>();
        }

        public static Player getPlayer()
        {
            if (_instance == null)
            {
                _instance = new Player();
            }

            return _instance;
        }

        public void Move(int x, int y)
        {
            xPosition = x;
            yPosition = y;
        }
    }
}
