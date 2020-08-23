using System;
using System.Collections.Generic;
using System.Text;

namespace PCMan_Game
{
    class Enemy
    {
        public int enemyWeapon { get; set; }
        public int DecreaseHealth(int playerHealth)
        {
            Console.WriteLine("Enemy");
            //enemyWeapon = 2;
            if (playerHealth >= enemyWeapon)
            {
                int x = playerHealth - enemyWeapon;
                Console.WriteLine($"Player health after enemy {x}");
                return playerHealth -= enemyWeapon;
            }
            else
            {
                Console.WriteLine("Player health after enemy 0");
                return 0;
            }


        }
    }
}

