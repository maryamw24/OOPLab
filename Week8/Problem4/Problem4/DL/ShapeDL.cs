﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem4.Bl;

namespace Problem4.DL
{
    class ShapeDL
    {
        public static List<Shape> Shapes= new List<Shape>();
        public static void AddShape(Shape s)
        {
            Shapes.Add(s);
        }
        public static void PrintShapes()
        {
            foreach(Shape s in Shapes)
            {
                Console.WriteLine(s.toString());
            }
        }
    }
}
