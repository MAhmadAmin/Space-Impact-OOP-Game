using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes.Enemies
{
    public class Genos : HorizontalEnemy
    {
        static readonly int Health = 5;
        static readonly int CollosionDamage = 5;
        static readonly int BulletDamage = 2;
        static readonly char BulletShape = (char)170;
        static readonly int KillReward = 5;
        static public char[,] EnemyShape = new char[,]
        {
            { ' ', ' ', '/', '%', 'o', '%', 'o', '%' },
            { '"', '"', '"', '%', '%', '%', '%', '%' }
        };

        public Genos(int x, int y) : base(x, y, Health)
        {
        }
    }
}
