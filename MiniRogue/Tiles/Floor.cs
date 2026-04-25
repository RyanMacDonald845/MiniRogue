using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue.Tiles
{
    internal class Floor : Tile
    {
        public static char Glyph { get; set; } = '.';

        public Floor(Position pos) : base("Floor", Glyph, pos, true) { }
    }
}
