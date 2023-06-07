using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Point
    {
        public int X;
        public int Y;
        public Point()
        {

        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetX(int X)
        {
            this.X = X;
        }
        public void SetY(int Y)
        {
            this.Y = Y;
        }
        public void SetXY(int X , int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double DistanceFromCords(int x, int y)
        {
            double value = (Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
            return Math.Sqrt(value);
        }
        public double DistanceFromObject(Point p)
        {
            double value = (Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
            return Math.Sqrt(value);
        }
        public double FromZero()
            {
            double value = (Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2));
            return Math.Sqrt(value);
        }
    }
}
