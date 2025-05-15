using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public class Bug : Character
    {
        private static int playerInitialHealth = 1;
        public Bug(int x, int y) : base(x, y, Health)
        {
        }
        static readonly int Health = 1;
        static readonly int CollosionDamage = 5;
        static readonly int KillReward = 2;
        static readonly string EnemyShape = "(@@";
    }
}
