using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Person
    {
        private string Name;
        private string Adress;
        public Person()
        {

        }
        public Person(string Name, string Adress)
        {
            this.Name = Name;
            this.Adress = Adress;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string SetName()
        {
            return Name;
        }
        public void GetAdress(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
        public virtual string toString()
        {
            return "Name: " + Name + ",Adress: " + Adress;
        }

    }
}
