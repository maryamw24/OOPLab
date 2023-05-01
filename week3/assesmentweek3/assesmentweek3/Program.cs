using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assesmentweek3.BL;
namespace assesmentweek3
    {

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Console.WriteLine(c.getArea());
            Console.WriteLine(c.getDiamter());
            Console.WriteLine(c.getCircumference());
            Console.ReadKey();

        }
    }
}
