using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Staff : Person
    {
        private string School;
        private int Pay;
        public Staff (): base()
        { }
        public Staff(string School, int Pay, string Name, string Adress) : base(Name, Adress)
        {
            this.School = School;
            this.Pay = Pay;
        }
        public override string toString()
        {
            return base.toString() + "School: " + School + "Pay: " + Pay; 
        }
    }
}
