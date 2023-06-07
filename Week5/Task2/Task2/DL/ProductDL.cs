using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;
using Task2.UI;

namespace Task2.DL
{
    class ProductDL
    {
        public static List<Product> ProductsList = new List<Product>();
        public static void AddProductToList(Product p)
        {
            ProductsList.Add(p);
        }
        public static void ViewProducts()
        {
            Console.WriteLine("Product Name".PadRight(20) + "Category".PadRight(20) + "Price".PadRight(20) + "Stock".PadRight(20) + "Min Stock".PadRight(20));
            foreach (Product i in ProductsList)
            {
                i.viewProducts();
            }
            Console.ReadKey();
        }
        public static int HighestPrice()
        {
            int largest = -1;
            int index = -1;
            for (int i = 0; i < ProductsList.Count; i++)
            {
                if (ProductsList[i].GetPrice() > largest)
                {
                    index = i;
                }
            }
            return index;
        }
        static void ViewTax()
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                ProductsList[i].SetTax(ProductsList[i].taxCalculator());
            }
            Console.WriteLine("Product".PadRight(20) + "Tax");
            for (int i = 0; i < ProductsList.Count; i++)
            {
                Console.WriteLine(ProductsList[i].GetName().PadRight(20) + ProductsList[i].GetTax());
            }
            Console.ReadKey();
        }
        static void orderProduxt()
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                if (ProductsList[i].GetQuantity() < ProductsList[i].GetMin_Quantity())
                {
                    Console.WriteLine(ProductsList[i].GetName());
                }
                else
                {
                    Console.WriteLine("no services available.");
                }
            }
            Console.ReadKey();
        }
        public static void OwnerMenu()
        {
            int option = UserUI.menu();
            if (option == 1)
            {
                Product p = ProductUI.addProduct();
                ProductDL.AddProductToList(p);
            }
            else if(option == 2)
            {
                ViewProducts();
            }
            else if(option == 3)
            {
                Console.WriteLine("Highest Price is of :" + (HighestPrice().ToString()));
            }
            else if(option == 4)
            {
                ViewTax();
            }
            else if(option == 5)
            {
                orderProduxt();
            }

        }
    }
}
