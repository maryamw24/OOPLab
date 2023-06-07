using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Bl
{
    class Circle : Shape
    {
        public float Radius;
        public Circle(float Radius, string ObjectType) : base(ObjectType)
        {
            this.Radius = Radius;
        }
        public void SetLength(float Radius)
        {
            this.Radius = Radius;
        }
        public float GetLength()
        {
            return Radius;
        }
        public override float GetArea()
        {
            return (3.14F *Radius *Radius);
        }
        public override string toString()
        {
            return base.toString() + ", CircleArea:" + GetArea();
        }
    }
}
