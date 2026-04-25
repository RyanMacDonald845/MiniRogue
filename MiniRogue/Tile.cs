using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class Tile : IDrawable, IWalkable
    {
        public string Type { get; protected set; }
        public char Symbol { get; protected set; }
        protected bool _isWalkable { get; set; }
        public Position Pos { get; protected set; }

        

        public Tile(string type, char symbol, Position position, bool isWalkable)
        {
            Type = type;
            Symbol = symbol;
            Pos = position;
            _isWalkable = isWalkable;
        }

        public Position GetPosition()
        {
            return Pos;
        }

        public Char GetSymbol()
        {
            return Symbol;
        }

        public bool IsWalkable()
        {
            return _isWalkable;
        }

        public override string ToString()
        {
            return $"{Symbol}";
        }
    }
}
