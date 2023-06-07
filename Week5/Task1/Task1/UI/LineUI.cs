using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1.UI
{
    class LineUI
    {
        public static int Menu()
        {
            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("4.Show the begin Point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the Length of the line");
            Console.WriteLine("7.Get the Gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Enter your option:");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Line LineInput()
        {
            Console.WriteLine("Start Point Input");
            Point p1 = PointInput();
            Console.WriteLine("End Point Input");
            Point p2 = PointInput();
            Line l = new Line(p1, p2);
            return l;
        }
        public static Point PointInput()
        {
            Console.WriteLine("Enter the start X coordinate:");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the start Y coordinate:");
            int Y = int.Parse(Console.ReadLine());
            Point p = new Point(X, Y);
            return p;
        }
        public static void ShowPoint(Point p)
        {
            Console.WriteLine("x.coordinate of point:" + p.X);
            Console.WriteLine("y.coordinate of point:" + p.Y);
        }
        public static void ShowDistancefromorigin(Point point)
        {
            double distance = point.FromZero();
            Console.WriteLine("The Distance from Origin is: " + distance);
        }
        
    }
}
