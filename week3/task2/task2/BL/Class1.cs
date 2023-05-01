using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Class1
    {
        public string name;
        public string category;
        public int price;
        public int quantity;
        public int min_quantity;
        public float tax;
       public float taxCalculator()
        {
            float tax = 0.0F;
            if (category == "grocery" || category == "Grocery")
            {
                tax = price * 0.1F;
            }
            else if (category == "Fruit" || category == "fruit")
            {
                tax = price * 0.05F;
            }
            return tax;
        }
        public void viewProducts()
        {
            
            Console.WriteLine(name.PadRight(20) + category.PadRight(20) + price + "               " + quantity + "                  " + min_quantity);
            
        }

    }
}
