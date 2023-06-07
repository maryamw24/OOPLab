using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    class Circle
    {
        private double Radius;
        private string Color;
        public Circle()
        {
            this.Radius = 1.0;
            this.Color = "red";
        }
        public Circle(double Radius, string Color)
        {
            this.Color = Color;
            this.Radius = Radius;
        }
        public Circle(double Radius)
        {
           
            this.Radius = Radius;
        }
        public void SetRadius(double Radius)
        {
            this.Radius = Radius;
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
        public double GetRadius()
        {
            return Radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public double GetArea()
        {
            return (3.14 *Radius*Radius);
        }
        public string toString()
        {
            return "Circle[ Radius= " + Radius.ToString() + ", Color= " + Color;
        }
    }
}
