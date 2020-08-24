using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace PCMan_Game
{
    public class Cell
    {
        public int xPosition { get; set; }
        public int yPosition { get; set; }
        public Content content { get; set; }
        public string rank { get; set; }
        public string weapon { get; set; }

        public override string ToString()
        {
            return $"x: {xPosition} y: {yPosition} content: {content} rank:{rank}";

        }
    }
    public class Map
    {
        public Cell[,] cells { get; set; }

        public int height { get; set; } = 4;
        public int width { get; set; } = 4;

      public Map()
        {
            
            cells = new Cell[height, width];
        }
        public void loadMap()
        {
            using (StreamReader r = new StreamReader(@"D:\Design Patterns\PCMan_Game\PCMan_Game\map.json.txt"))
            {
                //string json = r.ReadToEnd();
                //JavaScriptSerializer jss = new JavaScriptSerializer();
                //var jsonItems = jss.Deserialize<Cell>(json);

                //Console.WriteLine($"json {jsonItems}");

                string json = r.ReadToEnd();
                List<Cell> jsonItems = JsonConvert.DeserializeObject<List<Cell>>(json);

                Map[,] myMap = new Map[height, width];

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        //Console.WriteLine($"jsonitems {jsonItems}");
                        cells[i, j] = jsonItems[i];
                    }
                }
                //Console.WriteLine(cells[0, 0].xPosition);
                //for(int i=0; i<height; i++)
                //{
                //    for(int j=0; j<width; j++)
                //    {
                //        Console.WriteLine($"Row {i} Col {j} x: {cells[i,j].xPosition} y: {cells[i, j].yPosition} content: {cells[i, j].content} rank:{cells[i,j].rank}");
                //    }
                //}
                //return cells;

            }
        }
    }
}
