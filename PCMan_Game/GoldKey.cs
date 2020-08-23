using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class GoldKey : IKey
    {
        public void TakeKey()
        {
            Console.WriteLine("Take gold key");
        }
    }
}
