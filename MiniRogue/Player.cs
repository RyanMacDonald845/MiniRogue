using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class Player : Character
    {
        public Player(string name, char glyph, int health, int attackPower, Position position) : base(name, glyph, health, attackPower, position)
        {
            Color = ConsoleColor.Green;
        }
    }
}
