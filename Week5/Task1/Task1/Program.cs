using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line();
            Point p1 = new Point();
            Point p2 = new Point();
            int option;
            do
            {
                Console.Clear();
                option = LineUI.Menu();
                if(option == 1)
                {
                    l = LineUI.LineInput();
                }
                else if(option == 2)
                {
                    p1 = LineUI.PointInput();
                    l.SetStart(p1);
                }
                else if(option == 3)
                {
                    p2 = LineUI.PointInput();
                    l.SetEnd(p2);
                }
                else if(option == 4)
                {
                    p1 = l.GetStart();
                    LineUI.ShowPoint(p1);
                }
                else if (option == 5)
                {
                    p2 = l.GetEnd();
                    LineUI.ShowPoint(p2);
                }
                else if(option == 6)
                {
                    double Length = l.GetLength();
                    Console.WriteLine("Length of the line is :" + Length);
                }
                else if(option == 7)
                {
                    double gradient = l.GetGradient();
                    Console.WriteLine("Gradient of Line:" + gradient);
                }
                else if(option == 8 )
                {
                    LineUI.ShowDistancefromorigin(l.Start);
                }
                else if (option == 8)
                {
                    LineUI.ShowDistancefromorigin(l.End);
                }
                Console.ReadKey();
            }
            while (option != 11);
        }
    }
}
