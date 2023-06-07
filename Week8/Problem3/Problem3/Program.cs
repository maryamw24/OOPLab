using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3.BL;
using Problem3.DL;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Lucy");
            Cat c2 = new Cat("bella");
            Dog d1 = new Dog("Mucco");
            Dog d2 = new Dog("noor");
            AnimalDL.AddAnimal(c1);
            AnimalDL.AddAnimal(c2);
            AnimalDL.AddAnimal(d1);
            AnimalDL.AddAnimal(d2);
            AnimalDL.PrintAnimals();
            Console.ReadKey();

        }
    }
}
