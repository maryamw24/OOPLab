using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice.student.BL;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        static void task1()
        {
            Class1 student = new Class1();
            Console.WriteLine(student.name);
            Console.WriteLine(student.matricMarks);
            Console.WriteLine(student.fscMarls);
            Console.WriteLine(student.ecatMarks);
            Console.WriteLine(student.aggregate);
            Console.Read();
        }
        static void task2()
        {
            string name;
            Console.WriteLine("Enter any name:");
            name = Console.ReadLine();
            Class1 student = new Class1(name);
            Console.WriteLine(student.name);
            Console.Read();
        }
    }
}
