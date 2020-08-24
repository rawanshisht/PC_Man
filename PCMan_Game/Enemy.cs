using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class Enemy : ICellAction
    {
        public int enemyWeapon { get; set; }
        public void TakeAction(Player player)
        {
            DecreaseHealth(player);
        }
        public int DecreaseHealth(Player player)
        {
            if (player.health >= enemyWeapon)
            {
                int x = player.health - enemyWeapon;
                Console.WriteLine($"Player health after enemy {x}");
                return player.health -= enemyWeapon;
            }
            else
            {
                Console.WriteLine("Player health after enemy 0");
                return 0;
            }


        }

       
    }
}

