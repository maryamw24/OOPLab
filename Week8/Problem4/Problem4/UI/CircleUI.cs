using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.Bl ;

namespace Problem4.UI
{
    class CircleUI
    {
        public static Circle CircleInput()
        {
            Console.WriteLine("Enter the radius:");
            float Radius = float .Parse(Console.ReadLine());
            Circle c = new Circle(Radius, "Circle");
            return c;
        }
    }
}
