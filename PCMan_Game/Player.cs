using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class Player

    {
        private static Player _instance;

        public int health { get; set; }
        //list of keys and treasures
        protected Player()
        {
        }

        public static Player getPlayer()
        {
            if (_instance == null)
            {
                _instance = new Player();
            }

            return _instance;
        }
    }
}
