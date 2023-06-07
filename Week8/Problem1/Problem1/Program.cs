using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem1.BL;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(2.0, 2.0, "blue");
            Cylinder c3 = new Cylinder(3.0, 3.0, "blue");
            Console.WriteLine(c1.GetVolume().ToString());
            Console.WriteLine(c2.GetVolume().ToString());
            Console.WriteLine(c3.GetVolume().ToString());
            Console.ReadKey();
        }
    }
}
