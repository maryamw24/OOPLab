using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Task2.BL;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] Shape1 = new char[,] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', ' ', '@' } };
            char[,] Shape2 = new char[,] { { ' ', '@', ' ' }, { ' ', '@', '@' }, { ' ', '@', ' ' } };
            Boundary b = new Boundary(new Point(80, 0), new Point(0, 0), new Point(80,10), new Point(0,10));
            GameObject g1 = new GameObject(Shape1, new Point(50, 5), b, "LeftToRight");
            GameObject g2 = new GameObject(Shape2, new Point(7, 10), b, "RightToLeft");
            GameObject g3 = new GameObject(Shape1, new Point(20, 15), b, "LeftToRight", "pro");
            List<GameObject> List = new List<GameObject>();
            /*List.Add(g1);
            List.Add(g2);*/
            List.Add(g3);
            while(true)
            {
                Thread.Sleep(1200);
                foreach(GameObject g in List)
                {
                    g.EraseShape();
                    g.move();
                    g.DrawShape();
                }
            }
        }
    }
}
