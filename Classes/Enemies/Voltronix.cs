using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes.Enemies
{
    internal class Voltronix : VerticalEnemy
    {
        static readonly int Health = 50;
        static readonly int CollosionDamage = 3;
        static readonly int BulletDamage = 3;
        static readonly string enemy3Bullet = "<=-";
        static readonly int KillReward = 100;
        char[,] Enemy3 = new char[,]
        {
            { ' ', ' ', '~', '-', '#' },
            { '_', '-', 'o', '@', '|' },
            { ' ', '-', 'o', '@', '|' },
            { ' ', ' ', '~', '-', '#' }
        };

        public Voltronix(int x, int y) : base(x, y, Health)
        {
        }
    }
}
