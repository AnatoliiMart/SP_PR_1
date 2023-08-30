using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_PR_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];

            for (int i = 0; i < 5; i++)
            {
                points[i] = new Point(i, i+2);
            }
                                                                                       
            myMethod(points);
        }

        static void myMethod(Point[] points)
        {
            foreach (var point in points)
            {
                Thread trd = new Thread(PointsToString);
                trd.Start(point);
            }
        }

        static void PointsToString(object point)
        {
            Point p = (Point)point;
            Console.WriteLine(p.ToString());
        }
    }
}


    

