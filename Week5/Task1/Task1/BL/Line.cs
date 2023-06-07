using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Line
    {
        public Point Start;
        public Point End;
        public Line()
        {

        }
        public Line(Point Start, Point End)
        {
            this.Start = Start;
            this.End = End;
        }
        public Point GetStart()
        {
            return Start;
        }
        public Point GetEnd()
        {
            return End;
        }
        public void SetStart(Point Start)
        {
            this.Start = Start;
        }
        public void SetEnd(Point End)
        {
            this.End = End;
        }
        public double GetLength()
        {
            double value = (Math.Pow(Start.X - End.X, 2) + Math.Pow(Start.Y - End.Y, 2));
            return Math.Sqrt(value);
        }
        public double GetGradient()
        {
            return ((End.Y - Start.Y) / (End.X - Start.X));
        }
    }
}
