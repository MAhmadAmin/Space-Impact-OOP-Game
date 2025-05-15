using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public class Enemy : Character
    {
        public int CollosionDamage;
        readonly int BulletDamage;
        readonly char BulletShape;
        readonly int KillReward;
        public char[,] EnemyShape = new char[,]
        {
        };
        public Enemy(int x, int y, int health, int collosionDamage, int bulletDamage, string bulletShape, int killReward, char[,] EnemyShape) : base(x, y, health) 
        {
            CollosionDamage = collosionDamage;
            BulletDamage = bulletDamage;
            BulletShape = bulletShape[0];
            KillReward = killReward;
            EnemyShape = EnemyShape;
        }


        public virtual void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public override void Move()
        {

        }

        public override void Print()
        { }

        public override void Erase()
        { }
    }
}
