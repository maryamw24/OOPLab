using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
    class Cat: Mammal
    {
        public Cat (string Name) : base(Name)
        {

        }
        public override void Greets()
        {
            Console.WriteLine("Meowww");
        }
        public override string toString()
        {
            return "Cat["+ base.toString() + "]";
        }
    }
}
