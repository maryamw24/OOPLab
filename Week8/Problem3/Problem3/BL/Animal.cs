using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.BL
{
    class Animal
    {
        private string Name;
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public virtual string toString()
        {
            return "Animal[Name: " + Name + "]";
        }
        public virtual void Greets()
        {

        }
    }
}
