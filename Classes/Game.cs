using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceImpactGame.Classes
{
    public static class Game
    {
        private static Player player;
        private static string candiesCount;
        private static int score = 0;
        private static int currentLevel = 1;
        private static Maze maze;
        private static List<Enemy> enemiesList;
        private static List<Bullet> bulletsList;
        public static int EnemyMovCount = 0;
        public static int BulletsMovCount = 0;
        public static Player Player { get => player; set => player = value; }
        public static string CandiesCount { get => candiesCount; set => candiesCount = value; }
        public static int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        public static Maze Maze { get => maze; set => maze = value; }
        public static List<Enemy> EnemiesList { get => enemiesList; set => enemiesList = value; }
        internal static List<Bullet> BulletsList { get => bulletsList; set => bulletsList = value; }
        public static int Score { get => score; set => score = value; }

        public static void TickEnemy()
        {
            EnemyMovCount++;
            if (EnemyMovCount == 30)
            {
                foreach (var enemy in EnemiesList)
                {
                    enemy.Move();
                }
            }
        }

        public static void TickBullet()
        {
            EnemyMovCount++;
            if (EnemyMovCount == 20)
            {
                foreach (var bullet in BulletsList)
                {
                    bullet.Move();
                }
            }
        }

        public static void MoveAllEnemies()
        {
            foreach (var enemy in EnemiesList)
            {
                enemy.Move();
            }
        }
    }
}
