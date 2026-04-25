using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue.Tiles
{
    internal class Exit : Tile
    {
        public static char Glyph { get; set; } = 'E';
        public Exit(Position pos) : base("Exit", Glyph, pos, true) { }
    }
}
