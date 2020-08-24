using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class SilverKey :IKey, ISilver
    {
        
        public new void TakeAction(Player player)
        {
            player.keys.Add(this);
        }
    }
}
