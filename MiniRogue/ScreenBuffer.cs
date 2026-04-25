using MiniRogue.Tiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class ScreenBuffer
    {
        public Array rows { get; set; }
 
        public void InitializeMap(string map)
        {
            //Converts map into readable code
            rows = map
                    .Split(',')
                    .Select(r => r.Replace("\r", "").Replace("\n", ""))
                    .Where(r => r.Length > 0)
                    .ToArray();
        }

        public void RenderMap(List<Tile> tiles)
        {
            int oldPos = 0;

            foreach (Tile tile in tiles)
            {
                Console.Write(tile);
                if (tile.Pos.Y > oldPos)
                {
                    Console.Write("\n");
                }
                oldPos = tile.Pos.Y;
                
            }
        }

        public List<Tile> GetTiles()
        {
            int x = 0;
            int y = 0;
            char[] charTiles;
            List<Tile> tiles = new List<Tile> { };
            foreach (string row in rows)
            {
                y++;
                charTiles = row.ToCharArray();
                foreach(char tile in charTiles)
                {
                    x++;
                    if (tile == Floor.Glyph)
                    {
                        tiles.Add(new Floor(new Position(x, y)));
                    }
                    else if (tile == Start.Glyph)
                    {
                        tiles.Add(new Start(new Position(x, y)));
                    }
                    else if (tile == Exit.Glyph)
                    {
                        tiles.Add(new Exit(new Position(x, y)));
                    }
                    else
                    {
                        tiles.Add(new Wall(tile, new Position(x, y)));
                    }
                }
            }
            return tiles;
        }

        public static string map1 = @"
            __________________________,
            |....................E...|,
            |........................|,
            |........................|,
            |........................|,
            |.V......................+++++++++++++,
            |........................|           +,
            |________________________|           +,
                                                 +,
                                         ________+________,
                                         |...............|,
                                         |...............|,
                                         |_______________|,
        ";
    }
}
