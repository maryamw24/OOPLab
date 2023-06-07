using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Point
    {
        public int X;
        public int Y;
        public Point()
        {
            X = 0;
            Y = 0;
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
        public void SetXY(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
