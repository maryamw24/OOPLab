using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> Product = new List<Class1>();
            while(true)
            {
                Console.Clear();
                int choice;
                choice = menu();
                if(choice == 1)
                {
                    addProduct(Product);
                }
                else if(choice == 2)
                {
                    Console.WriteLine("Product Name".PadRight(20) + "Category".PadRight(20) + "Price".PadRight(20) + "Stock".PadRight(20) + "Min Stock".PadRight(20));
                    foreach(Class1 i in Product )
                    {
                        i.viewProducts();
                    }
                    Console.ReadKey();

                }
                else if(choice == 3)
                {
                    int index = HighestPrice(Product);
                    Console.WriteLine(Product[index].name);
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    ViewTax(Product);
                }
                else if (choice == 5)
                {
                    orderProduxt(Product);
                }

            }

        }
        static int menu()
        {
            int choice;
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View Product");
            Console.WriteLine("3.Search highest Price Product");
            Console.WriteLine("4.View Sales Tax of Product");
            Console.WriteLine("5.Products to be ordered Product");
            Console.WriteLine("Enter your choice.");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        static void addProduct(List<Class1> Product)
        {
            Console.Clear();
            Class1 p = new Class1();
            Console.WriteLine("Enter the name of the product:");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter the category of the product:");
            p.category = Console.ReadLine();
            Console.WriteLine("Enter the price of the product:");
            p.price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total quantity of the product:");
            p.quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the product:");
            p.min_quantity = int.Parse(Console.ReadLine());
            Product.Add(p);
        }
       
        static int HighestPrice(List<Class1> Product)
        {
            int largest = -1;
            int index = -1;
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].price > largest)
                {
                    index = i;
                }
            }
            return index;
        }
       
        static void ViewTax(List<Class1> Product)
        {
            for (int i = 0; i < Product.Count; i++)
            {
                Product[i].tax = Product[i].taxCalculator();
            }
            Console.WriteLine("Product".PadRight(20) + "Tax");
            for (int i = 0; i < Product.Count; i++)
            {
                Console.WriteLine(Product[i].name.PadRight(20) + Product[i].tax);
            }
            Console.ReadKey();
        }
        static void orderProduxt(List<Class1> Product)
        {
            for(int i = 0; i < Product.Count; i++)
            {
                if(Product[i].quantity < Product[i].min_quantity)
                {
                    Console.WriteLine(Product[i].name);
                }
                else
                {
                    Console.WriteLine("no services available.");
                }
            }
            Console.ReadKey();
        }
    }
}
