using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
    class Dog : Mammal
    {
        public Dog(string Name) : base(Name)
        {

        }
        public override void Greets()
        {
            Console.WriteLine("Wooof");
        }
        public override string toString()
        {
            return "Dog["+base.toString()+ "]";
        }
    }
}
