using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4.Bl
{
    class Shape
    {
        private string ObjectType;
        public Shape(string ObjectType)
        {
            this.ObjectType = ObjectType;
        }
        public void SetType(string ObjectType)
        {
            this.ObjectType = ObjectType;
        }
        public string GetType()
        {
            return ObjectType;
        }
        public virtual float GetArea()
        {
            return 0.0F;
        }
        public virtual string toString()
        {
            return "Type:" +GetType();
        }
    }
}
