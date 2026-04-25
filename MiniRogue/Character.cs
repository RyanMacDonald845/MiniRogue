using System;
using System.Collections.Generic;
using System.Text;

namespace MiniRogue
{
    internal class Character : IDrawable
    {
        public ConsoleColor Color { get; set;  }
        private Position _position;
        public Position Position
        {
            get { return _position; }
            protected set
            {
                _position = value;
            }
        }
        private int _health;
        public int Health
        {
            get { return  _health; }
            protected set
            {
                _health = value;
            }
        }
        private int _attackPower;
        public int AttackPower
        {
            get { return _attackPower; }
            protected set
            {
                _attackPower = value;
            }
        }
        private int _defense;
        public int Defense
        {
            get { return  _defense; }
            protected set
            {
                _defense = value;
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            protected set
            {
                _name = value;
            }
        }
        private char _glyph;
        public char Glyph
        {
            get { return _glyph; }
            protected set
            {
                _glyph = value;
            }
        }

        public Character(string name, char glyph, int health, int attackPower, Position position)
        {
            Name = name;
            Glyph = glyph;
            Health = health;
            AttackPower = attackPower;
            Position = position;
        }

        //returns the amount of health left on the character
        public int Attack(Character character)
        {
            character.Health += character._defense - AttackPower;
            return character._health;
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
