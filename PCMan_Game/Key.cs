using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    //Context
    public class Key : ICellAction
    {
        private IKey _key;

        public Key(IKey key)
        {
            _key = key;
        }

        public void TakeAction(Player player)
        {
            _key.TakeAction(player);
        }

        //public void TakeKey()
        //{
        //    _key.TakeKey();
        //}
      
    }
}
