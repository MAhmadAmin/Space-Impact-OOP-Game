using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes.Enemies
{
    public class Megatronix : HorizontalEnemy
    {
        static readonly int Health = 10;
        static readonly int CollosionDamage = 5;
        static readonly int BulletDamage = 2;
        static readonly string enemy2Bullet = "-=";
        static readonly int KillReward = 10;
        char[,] EnemyShape = new char[,]
        {
            { ' ', ' ', '-', '-', '#' },
            { '<', '-', '|', 'o', '|' },
            { ' ', ' ', '-', '-', '#' }
        };


        public Megatronix(int x, int y) : base(x, y, Health)
        {
        }
    }
}
