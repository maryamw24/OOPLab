using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
namespace Task1.UI
{
    class CoffeeShopUI
    {
        public static void PrintOrders(List<string> Orders)
        {
            Console.WriteLine("Name");
            foreach(String i in Orders)
            {
                Console.WriteLine(i); 
            }
            Console.ReadKey();
        }
        
        public static void PrintItems(string name)
        {
            Console.WriteLine(name);
        }
       
    }
}
