using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem2.BL;
using Problem2.DL;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Bsc.ComputerScience", 1, 30000, "maryam", "Lahore");
            Student s2 = new Student("Bsc", 1, 30000, "m", "Lahore");
            Staff st1 = new Staff("s" , 130000 , "norr" , "Lahore");
            Staff st2 = new Staff("s" , 10000 , "Rameen" , "Lahore");
            PersonDL.AddPerson(s1);
            PersonDL.AddPerson(s2);
            PersonDL.AddPerson(st1);
            PersonDL.AddPerson(st2);
            foreach(Person p in PersonDL.PersonList)
            {
                Console.WriteLine(p.toString());
            }
            Console.ReadKey();
        }
    }
}
