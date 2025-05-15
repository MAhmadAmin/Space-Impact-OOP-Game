using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using SpaceImpactGame.Classes;
using SpaceImpactGame.UI;

namespace SpaceImpactGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MazeUI MazeUIInstance = new MazeUI(new Maze(1, 2));
            MazeUIInstance.PrintMaze();
            Utility.PrintLevel();
            Utility.PrintScore();
            Player p = new Player(5, 5);
            Utility.PrintHealth(p);

            p.Print();

            Console.ReadKey();

            while (true)
            {
                Thread.Sleep(90);
                p.Move();
            }
        }
    }
}
