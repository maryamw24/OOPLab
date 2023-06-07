using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1.BL
{
    class Cylinder : Circle
    {
        private double Hieght;
        public Cylinder() : base()
        {
            this.Hieght = 1.0;
        }
        public Cylinder(double Radius) : base(Radius)
        {
            
        }
        public Cylinder(double Radius, string Color): base(Radius, Color)
        {
            
        }
        public Cylinder(double Hieght, double Radius, string Color): base(Radius, Color)
        {
            this.Hieght = Hieght;
        }
        public double GetHieght()
        {
            return Hieght;
                }
        public void SetHieght(double Hieght)
        {
            this.Hieght = Hieght;
        }
        public double GetVolume()
        {
            return base.GetArea() * Hieght;
        }
        
    }
}
