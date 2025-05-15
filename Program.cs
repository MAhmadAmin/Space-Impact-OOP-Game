using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using SpaceImpactGame.Classes;
using SpaceImpactGame.UI;
using SpaceImpactGame.Classes.Enemies;

namespace SpaceImpactGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Random random = new Random();

            MazeUI MazeUIInstance = new MazeUI(new Maze(1, 2));
            MazeUIInstance.PrintMaze();
            Utility.PrintLevel();
            Utility.PrintScore();

            Game.Player = new Player(5, 5);
            Game.Player.Print();

            Utility.PrintHealth((Player)Game.Player);

            int BugGenerationTime = 11;
            int GenosGenerationTime = 51;


            while (true)
            {
                Thread.Sleep(100);
                Tick.TickCount++;
                if (Tick.TickCount > 99)
                    Tick.TickCount = 0;

                Game.Player.Move();

                if (BugGenerationTime > 10)
                { 
                    Game.BugsList.Add(new Bug(65, random.Next(5, 26)));
                    BugGenerationTime = 0;
                }

                for (int i = Game.BugsList.Count - 1; i >= 0; i--)
                {
                    Bug bug = Game.BugsList[i];
                    bug.Move();
                    if (CollosionDetection.DetectCollosion(bug.X, bug.Y))
                    {
                        bug.Erase();
                        Game.Player.Print();
                        Game.BugsList.RemoveAt(i);
                        Game.Player.Health -= Bug.CollosionDamage;
                        Utility.PrintHealth(Game.Player);
                    }

                }

                for (int i = Game.BugsList.Count - 1; i >= 0; i--)
                {
                    Bug bug = Game.BugsList[i];
                    if (bug.X < 4)
                    {
                        bug.Erase();
                        Game.BugsList.RemoveAt(i);
                    }
                }

                if(GenosGenerationTime >= 51)
                {
                    Game.EnemiesList.Add(new Genos(62, random.Next(5, 26)));
                    GenosGenerationTime =0;
                }

                for(int i = Game.EnemiesList.Count - 1; i>=0; i--)
                {
                    Enemy enemy = Game.EnemiesList[i];
                    enemy.Move();
                    if(CollosionDetection.DetectCollosion(enemy.X, enemy.Y))
                    {
                        enemy.Erase();
                        Game.Player.Print();
                        Game.EnemiesList.RemoveAt(i);
                        Game.Player.Health -= enemy.CollosionDamage;
                        Utility.PrintHealth(Game.Player);
                    }
                }

                for(int i = Game.EnemiesList.Count -1; i>=0; i--)
                {
                    Enemy enemy = Game.EnemiesList[i];
                    if(enemy.X < 4)
                    {
                        enemy.Erase();
                        Game.EnemiesList.RemoveAt(i);
                    }
                }

                GenosGenerationTime++;
                BugGenerationTime++;
            }
        }
    }
}
