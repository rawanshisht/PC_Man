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
            Game Game = Game.startGame();
            Game.PlayGame();

        }
    }
}
