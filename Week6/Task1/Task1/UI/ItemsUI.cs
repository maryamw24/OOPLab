using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
namespace Task1.UI
{
    class ItemsUI
    {
        public static int Menu()
        {
            int option;
            Console.WriteLine("1.Add a Menu item");
            Console.WriteLine("2.View the Cheapest Item in the menu");
            Console.WriteLine("3.View the Drink’s Menu");
            Console.WriteLine("4.View the Food’s Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("7.View the Orders’s List");
            Console.WriteLine("8.Total Payable Amount");
            Console.WriteLine("9.Exit");
            Console.WriteLine("Enter your option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Items ItemInput()
        {
            Console.WriteLine("Enter the name of item:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the type od item(drink/ food):");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the price of item:");
            int Price = int.Parse(Console.ReadLine());
            Items i = new Items(Name, type, Price);
            return i;
        }
    }
}
