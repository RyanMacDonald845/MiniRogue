using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue.Tiles
{
    internal class Wall : Tile
    {

        public Wall(char symbol, Position position) : base("Wall", symbol, position, false)
        {
        }

    }
}
