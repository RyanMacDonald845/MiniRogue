using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class Character : IDrawable
    {
        private Position position;
        public Position Position
        {
            get { return position; }
            protected set
            {
                position = value;
            }
        }
        private int health;
        public int Health
        {
            get { return  health; }
            protected set
            {
                health = value;
            }
        }
        private int attackPower;
        public int AttackPower
        {
            get { return attackPower; }
            protected set
            {
                attackPower = value;
            }
        }
        private int defense;
        public int Defense
        {
            get { return  defense; }
            protected set
            {
                defense = value;
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            protected set
            {
                name = value;
            }
        }
        private char glyph;
        public char Glyph
        {
            get { return glyph; }
            protected set
            {
                glyph = value;
            }
        }

        public Character(char glyph)
        {
            Glyph = glyph;
        }

        //returns the amount of health left on the character
        public int Attack(Character character)
        {
            character.Health += character.defense - AttackPower;
            return character.health;
        }

        public void AddHealth(int amount)
        {
            Health += amount;
        }
        public void SubtractHealth(int amount)
        {
            Health -= amount;
        }

        public void AddAttackPower(int amount)
        {
            AttackPower += amount;
        }
        public void SubtractAttackPower(int amount)
        {
            AttackPower -= amount;
        }

        public void AddDefense(int amount)
        {
            Defense += amount;
        }
        public void SubtractDefense(int amount)
        {
            Defense -= amount;
        }
        public Position GetPosition()
        {
            return Position;
        }
        public char GetSymbol()
        {
            return Glyph;
        }
    }
}
