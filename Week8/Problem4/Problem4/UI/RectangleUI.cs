using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.Bl;

namespace Problem4.UI
{
    class RectangleUI
    {
        public static Rectangle RectangleInput()
        {
            Console.WriteLine("Enter the Lenght:");
            float Lenght = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Width:");
            float Width = float.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(Lenght,Width,  "Rectangle");
            return r;
        }
    }
}
