using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public class Enemy : Character
    {
        public Enemy(int x, int y, int health) : base(x, y, health) 
        { }


        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public void Move()
        {

        }
    }
}
