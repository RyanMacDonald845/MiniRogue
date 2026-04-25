using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    public class Game
    {
        private ScreenBuffer _buffer;
        private Level _currentLevel;
        private Player _player;
        private List<Tile> _tiles;

        public void Initialize()
        {
            _buffer = new ScreenBuffer();
            _buffer.InitializeMap(ScreenBuffer.map1);
            _tiles = _buffer.GetTiles();

            _player = new Player("Hero", '@', 12, 4, new Position (0, 0));

            _currentLevel = new Level(_player, _tiles);
            
        }

        public void Run()
        {
            Update();
            Draw();
            HandleInput();
        }

        public void Draw()
        {
            _buffer.RenderMap(_tiles);
        }
        public void HandleInput()
        {

        }

        public void Update()
        {

        }
        public void LoadNextLevel()
        {

        }
    }
}
