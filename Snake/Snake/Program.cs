using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p2 = new Point(4, 4, '#');

            int arenaLength = 100;
            int arenaHeight = 25;

            HorLine LineUp = new HorLine(0, arenaLength, 0, '#');
            LineUp.Draw();

            HorLine LineDown = new HorLine(0, arenaLength, arenaHeight, '#');
            LineDown.Draw();

            VertLine LineLeft = new VertLine(0, arenaHeight, 0, '#');
            LineLeft.Draw();

            VertLine LineRight = new VertLine(0, arenaHeight, arenaLength, '#');
            LineRight.Draw();

            Console.ReadKey();
        }


    }
}
