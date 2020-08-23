using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    //Context
    class Box
    {
        private IBox _box;

        public Box(IBox box)
        {
            this._box = box;
        }
        public void increaseHealth()
        {
            _box.increaseHealth();
        }
        public void increaseWeapon()
        {
            _box.increaseWeapon();
        }
    }
}
