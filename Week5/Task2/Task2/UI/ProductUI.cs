using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    class ProductUI
    {
        public static Product addProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the product:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the category of the product:");
            string category = Console.ReadLine();
            Console.WriteLine("Enter the price of the product:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total quantity of the product:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimum quantity of the product:");
            int min_quantity = int.Parse(Console.ReadLine());
            Product p = new Product(name, price, category, quantity, min_quantity);
            return p;
           
        }
        
    }
}
