using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class GoldKey : IKey, IGold
    {
        public GoldKey()
        {

        }
        public new void TakeAction(Player player)
        {
            player.keys.Add(this);
        }
        //public void TakeKey()
        //{
        //    Console.WriteLine("Take gold key");
        //}
    }
}
