using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    //Context
    class Key
    {
        private IKey _key;

        public Key(IKey key)
        {
            this._key = key;
        }

        public void TakeKey()
        {
            _key.TakeKey();
        }
      
    }
}
