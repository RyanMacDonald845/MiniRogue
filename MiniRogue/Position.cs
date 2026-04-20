using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    public class Position
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            private set
            {
                x = value;
            }
        }
        private int y;
        public int Y
        {
            get
            {
                return y;
            }
            private set
            {
                y = value;
            }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position GetNorthPos()
        {
            return new Position(X + 1, Y);
        }        

        public Position GetSouthPos()
        {
            return new Position(X - 1, Y);
        }

        public Position GetWestPos()
        {
            return new Position(X, Y - 1);
        }

        public Position GetEastPos()
        {
            return new Position(x, y + 1);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Position pos) { 
                if (pos == this) return true;
            }
            return false;
        }

        public static bool operator ==(Position left, Position right) => (left.x == right.x) && (left.y == right.y);
        public static bool operator !=(Position left, Position right) => (left.x == right.x) || (left.y == right.y);
        public static Position operator +(Position left, Position right) => new Position((left.x + right.x), (left.y + right.y));
        public static Position operator -(Position left, Position right) => new Position((left.x - right.x), (left.y - right.y));





    }
}
