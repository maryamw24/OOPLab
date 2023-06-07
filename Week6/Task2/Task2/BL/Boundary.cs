using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.BL
{
    class Boundary
    {
        public Point TopLeft;
        public Point BottomLeft;
        public Point TopRight;
        public Point BottomRight;
        public Boundary()
        {
            TopLeft.SetXY(0,0);
            BottomLeft.SetXY(90, 0);
            TopRight.SetXY(0, 90);
            BottomRight.SetXY(90, 90);
    
        }
        public Boundary(Point TopRight, Point TopLeft, Point BottomRight, Point BottomLeft)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomRight = BottomRight;
            this.BottomLeft = BottomLeft;
        }
 
    }
}
