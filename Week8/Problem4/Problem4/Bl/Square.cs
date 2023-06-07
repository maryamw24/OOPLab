using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Bl
{
    class Square : Shape
    {
        public float Length;
        public Square(float Length, string ObjectType) : base(ObjectType)
        {
            this.Length = Length;
        }
        public void SetLength(float Length)
        {
            this.Length = Length;
        }
        public float GetLength()
        {
            return Length;
        }
        public override float GetArea()
        {
            return Length * Length;
        }
        public override string toString()
        {
            return base.toString() + ", SquareArea:" + GetArea();
        }

    }
}
