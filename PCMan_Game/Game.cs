using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class Game

    {
        private static Game _instance;
        protected Game()
        {
        }

        public static Game startGame()
        {
            if (_instance == null)
            {
                _instance = new Game();
            }

            return _instance;
        }
    }
}
