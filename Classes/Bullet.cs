using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    abstract class Bullet : GameEntity
    {
        private int _speed;
        private int _damage;
        private Enemy _shooter;
        private char _symbol;

        public int Speed { get => _speed; set => _speed = value; }
        public int Damage { get => _damage; set => _damage = value; }
        public Enemy Shooter { get => _shooter; set => _shooter = value; }
        public bool IsActive { get => IsActive; set => IsActive = value; }
        public char Symbol { get => _symbol; set => _symbol = value; }

        public Bullet(int x, int y) : base(x, y) { }

        public void Move()
        {
            //asdf
        }
    }
}
