using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903ML08a
{
    class Point
    {
        //operator overloading 
        //static/compile time polymorphism
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //overload '+' operator
         public static Point operator+(Point p1, Point p2)
        {
            Point tempPoint = new Point(0, 0);
            tempPoint.X = p1.X + p2.X;
            tempPoint.Y = p1.Y + p2.Y;
            return tempPoint;
        }

      
    }
}
