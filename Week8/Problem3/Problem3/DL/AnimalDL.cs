using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3.BL;

namespace Problem3.DL
{
    class AnimalDL
    {
        public static List<Animal> AnimalList= new List<Animal>();
        public static void AddAnimal(Animal a)
        {
            AnimalList.Add(a);
        }
        public static void PrintAnimals()
        {
            foreach(Animal a in AnimalList)
            {
                Console.WriteLine(a.toString());
                a.Greets();
            }
        }

    }
}
