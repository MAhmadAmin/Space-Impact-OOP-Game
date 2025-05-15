using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public abstract class Character : GameEntity
    {
        private int health;
        
        public int Health { get => health; set => health = value; }

        public Character(int x, int y, int health) : base(x, y)
        {
            Health = health;
        }
        public abstract void Print();

        public abstract void Erase();

        public abstract void Move();
    }
}
