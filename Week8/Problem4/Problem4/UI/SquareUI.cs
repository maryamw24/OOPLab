using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.Bl;

namespace Problem4.UI
{
    class SquareUI
    {
        public static Square SquareInput()
        {
            Console.WriteLine("Enter the Lenght:");
            float Lenght = float.Parse(Console.ReadLine());
            Square s = new Square(Lenght, "Circle");
            return s;
        }
    }
}
