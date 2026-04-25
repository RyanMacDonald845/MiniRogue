using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class Level
    {
        private Player _player;
        private List<Tile> _tiles;
        public static int floorLevel { get; private set; } = 0;

        public Level(Player player, List<Tile> tiles)
        {
            floorLevel++;
            this._player = player;
            this._tiles = tiles;
        }
    }
}
