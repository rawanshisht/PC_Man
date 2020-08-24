using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class BronzeKey: IKey, IBronze
    {
        public new void TakeAction(Player player)
        {
            player.keys.Add(this);
        }
    }
}
