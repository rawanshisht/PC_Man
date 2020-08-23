using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace PCMan_Game
{
    public class Map
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public string content { get; set; }
        public string key { get; set; }
        public string weapon { get; set; }

        //public Map(int x, int y, string cont, string k, string w)
        //{
        //    xPosition = x;
        //    yPosition = y;
        //    content = cont;
        //    key = k;
        //    weapon = w;

        //}
        public Map[,] loadMap()
        {
            using (StreamReader r = new StreamReader(@"D:\Design Patterns\PCMan_Game\PCMan_Game\map.json.txt"))
            {
                string json = r.ReadToEnd();
                List<Map> jsonItems = JsonConvert.DeserializeObject<List<Map>>(json);
                int height = 4;
                int width = 4;
                Map[,] myMap = new Map[height, width];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        myMap[i, j] = jsonItems[i];
                    }
                }
                Console.WriteLine(myMap[0, 0].xPosition);
                return myMap;

            }
        }
    }
}
