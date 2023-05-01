using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Details.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Class1[] Products = new Class1[10];
            int choice = Menu();
            if(choice == 1)
            {
                Products[count] = AddProduct();
                count++;
            }
            if(choice == 2)
            {
                ViewProducts(Products, count);
            }
            if(choice == 3)
            {
                TotalWorth(Products, count);
            }

        }
        static int Menu()
        {
            int choice;
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2. View Product");
            Console.WriteLine("3. View Worth");
            choice = int. Parse(Console.ReadLine());
            return choice;
        }
        static Class1 AddProduct()
        {
        
            
                Class1 s1 = new Class1();
                Console.WriteLine("Enter the ID of the Product:");
                s1.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the Product:");
                s1.Name =Console.ReadLine();
                Console.WriteLine("Enter the category of the Product:");
                s1.category = Console.ReadLine();
                Console.WriteLine("Enter the price of the product:");
                s1.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the BrandName of Product");
                s1.BrandName = Console.ReadLine();
            Console.WriteLine("Enter the Country of Product");
            s1.Country = Console.ReadLine();
            return s1;
            
        }
        static void ViewProducts(Class1[] s, int Count)
        {
            for (int i = 0; i <Count; i++)
            {
                Console.WriteLine("ID:" + s[i].ID + " Name:" + s[i].Name + " Category:" + s[i].category + " Price:" + s[i].Price + " BrandNAme:" + s[i].BrandName + "Country:" + s[i].Country);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void TotalWorth(Class1[] Product, int Count)
        {
            int sum = 0;
            for(int i = 0; i < Count; i++)
            {
                sum = sum + Product[i].Price;
            }
            Console.WriteLine("Total worth is : " + sum);
            Console.ReadKey();
        }
    }
}
