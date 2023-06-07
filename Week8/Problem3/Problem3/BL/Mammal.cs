using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
    class Mammal : Animal
    {
        public Mammal (string Name): base(Name)
        {
        }
        public override string toString()
        {
            return "Mammal["+base.toString()+"]";
        }
        public override void Greets()
        {

        }
    }
}
