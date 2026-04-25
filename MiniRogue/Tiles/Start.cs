using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue.Tiles
{
    internal class Start : Tile
    {
        public static char Glyph { get; set; } = 'V';
        public Start(Position pos) : base("Start", Glyph, pos, true) { }
    }
}
