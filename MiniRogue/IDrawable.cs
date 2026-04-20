using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    public interface IDrawable
    {
        Position GetPosition();
        Char GetSymbol();
    }
}
