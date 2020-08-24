using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCMan_Game
{
    public enum Content
    {
        None, //0
        Treasure, //1
        Key, //2
        Enemy, //3
        Diamond //4
    }
    class Game

    {
        private static Game _instance;

        private Map map { get; set; }  //to set levels - single responsibility of loading map level
        //private Map[,] fullMap { get; set; }
        private Player player { get; set; }

        private Game()
        {
            player = Player.getPlayer();
        }

        public static Game startGame()
        {
            if (_instance == null)
            {
                _instance = new Game();
            }

            return _instance;
        }
        public void Move(Char input)
        {
            switch (input)
            {
                case 'w':
                case 'W':
                    if (player.yPosition == 0)
                    {
                        player.yPosition = map.height - 1;
                    }
                    else
                    {
                        player.yPosition--;
                    }
                    break;
                case 'a':
                case 'A':
                    if (player.xPosition == 0)
                    {
                        player.xPosition = map.width - 1;
                    }
                    else
                    {
                        player.xPosition--;
                    }
                    break;
                case 's':
                case 'S':
                    if (player.yPosition == map.height - 1)
                    {
                        player.yPosition = 0;
                    }
                    else
                    {
                        player.yPosition++;
                    }
                    break;
                case 'd':
                case 'D':
                    if (player.xPosition == map.width - 1)
                    {
                        player.xPosition = 0;
                    }
                    else
                    {
                        player.xPosition++;
                    }
                    break;
                default:
                    Console.WriteLine("Unknown!");
                    break;

            }

            Action(map.cells[player.xPosition, player.yPosition].content);

        }
        public void Action(Content content)
        {
            ICellAction cellAction;
            switch (content)
            {
                case Content.None:
                    Console.WriteLine("Empty Cell");
                    break;
                case Content.Treasure:
                    switch (map.cells[player.xPosition, player.yPosition].rank)
                    {
                        case "Gold":
                            if (player.keys.FirstOrDefault(key => key is GoldKey) != null)
                            {
                                cellAction = new Box(new GoldBox());
                                cellAction.TakeAction(player);

                            }
                            break;
                        case "Silver":
                            if (player.keys.FirstOrDefault(key => key is SilverKey) != null)
                            {
                                cellAction = new Box(new SilverBox());
                                cellAction.TakeAction(player);

                            }
                            Console.WriteLine("Silver Treasure");
                            break;
                        case "Bronze":
                            if (player.keys.FirstOrDefault(key => key is BronzeKey) != null)
                            {
                                cellAction = new Box(new BronzeBox());
                                cellAction.TakeAction(player);

                            }
                            break;

                    }


                    break;
                case Content.Key:
                    
                    switch (map.cells[player.xPosition, player.yPosition].rank)
                    {
                        case "Gold":
                            cellAction = new Key(new GoldKey());
                            cellAction.TakeAction(player);
                            
                            break;
                        case "Silver":
                            cellAction = new Key(new SilverKey());
                            cellAction.TakeAction(player);
                            Console.WriteLine("Silver Key");
                            break;
                        case "Bronze":
                            cellAction = new Key(new BronzeKey());
                            cellAction.TakeAction(player);
                            break;

                    }

                    break;
                case Content.Enemy:
                    cellAction = new Enemy();
                    cellAction.TakeAction(player);
                    break;
                case Content.Diamond:
                    Console.WriteLine("YOU WON!!!");
                    break;
                default:
                    break;
            }
        }
        public void PlayGame()
        {
            map = new Map();
            map.loadMap();

            Console.WriteLine("Enter W/A/S/D to play");

            char input = '0';
            do {
                char.TryParse(Console.ReadLine().ToString(), out input);
                Move(input);

            } while(input!= '0'); //when enemy wins or he gets the dimond
            //put flag is game over and set it in case = diamond or enemy;


        }
    }
}
