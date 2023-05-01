using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice.student.BL
    
{
    class Class1
    {
        public Class1()
            {
            Console.WriteLine("Default constructor is formed");
            name = "Maryam";
            matricMarks = 1053F;
            fscMarls = 1022F;
            ecatMarks = 121F;
            aggregate = 71.9F;
            }
        public Class1(string name)
        {
            this.name = name;
        }

        public string name;
        public float matricMarks;
        public float fscMarls;
        public float ecatMarks;
        public float aggregate;
    }
}