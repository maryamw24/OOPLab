using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Bl
{
    class Rectangle : Shape
    {
        public float Length;
        public float Width;
        public Rectangle(float Length,float Width, string ObjectType) : base(ObjectType)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public void SetLength(float Length)
        {
            this.Length = Length;
        }
        public float GetLength()
        {
            return Length;
        }
        public void SetWidth(float Width)
        {
            this.Width = Width;
        }
        public float GetWidth()
        {
            return Width;
        }
        public override float GetArea()
        {
            
            return this.Length * this.Width;
        }
        public override string toString()
        {
            return base.toString() + ", RectangleArea:" + this.GetArea().ToString();
        }
    }
}
