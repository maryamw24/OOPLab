using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
   public  class Product
    {
        public string name;
        public string category;
        public int price;
        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public float CalculateTax()
        {
            return price * 0.2f;
        }


            }
    
}
