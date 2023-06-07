using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    public class Customer
    {
        public string name;
        public string phoneNumber;
        public string adress;
        public List<Product> purchased = new List<Product>();
        public List<Product> GetProducts()
        {
            return purchased;
        }
        public void AddProduct(Product p)
        {
            purchased.Add(p);
        }
    }
}
