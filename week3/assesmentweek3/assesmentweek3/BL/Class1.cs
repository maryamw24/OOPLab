using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesmentweek3.BL
{
    class Circle
    {
        public double radius;
        public string color;
        public double Area;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public Circle(Circle c)
        {
            radius = c.radius;
            color = c.color;
        }
        public double getArea()
        {
            return 3.14 * (radius*radius);
        }
        public double getDiamter()
        {
            return 2 * radius;
        }
        public double getCircumference()
        {
            return 2 * 3.14 * radius;
        }
	 
    }
}
