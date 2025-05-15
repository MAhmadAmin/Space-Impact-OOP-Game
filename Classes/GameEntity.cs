using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public class GameEntity
    {
        private int x;
        private int y;
        private Direction direction;

        
        public Direction Direction { get => direction; set => direction = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public GameEntity(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
