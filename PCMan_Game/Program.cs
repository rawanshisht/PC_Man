using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace PCMan_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            Map map = new Map();
            map.loadMap();
            
            Player player1 = Player.getPlayer();
            Player player2 = Player.getPlayer();

            Game game = Game.startGame();
            
            player1.health = 10;
            Enemy enemy = new Enemy();

            enemy.DecreaseHealth(player1.health);

           // KeyType key = KeyType.Gold;
            //keyStrategy goldKey = new keyStrategy(key);
            //Console.WriteLine(goldKey.health);


        }
    }
}
