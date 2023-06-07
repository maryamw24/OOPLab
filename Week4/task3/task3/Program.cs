using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Product p = new Product("m", "1", 200);
            Customer c = new Customer();
            c.AddProduct(p);
            Console.WriteLine("Tax:" + p.CalculateTax());
            Product p1 = new Product("l", "2", 500);
            c.AddProduct(p1);
            Console.WriteLine("Tax:" + p1.CalculateTax());
            List<Product> purchased = c.GetProducts();
            for(int i = 0; i < purchased.Count; i++)
            {
                sum = sum + purchased[i].price;
            }
            Console.WriteLine("total purchases count :" + purchased.Count);
            Console.WriteLine("total purchases:" + sum);
            Console.ReadKey();

        }
    }
}
