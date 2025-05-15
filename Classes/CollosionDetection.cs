using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceImpactGame.UI;

namespace SpaceImpactGame.Classes
{
    static public class CollosionDetection
    {
        static public bool DetectCollosion(int x, int y)
        {
            for (int i = 0; i < 7; i++) // checks player width
                for (int j = 0; j < 3; j++) // checks player height
                    if (x == Game.Player.X +i + 1 && y == Game.Player.Y + j)   // all condition for collision excluding space.
                        return true;
            return false;

            //if(x == Game.Player.X + 7 && (y == Game.Player.Y || y == Game.Player.Y + 1 || y == Game.Player.Y + 2))
            //    return true;
            //return false;
        }
    }
}
