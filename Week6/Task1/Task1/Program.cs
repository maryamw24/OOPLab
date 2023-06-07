using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;
using Task1.UI;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            CoffeeShop c = new CoffeeShop();
            do
            {
                Console.Clear();
                option = ItemsUI.Menu();
                if(option == 1)
                {
                    
                    Items i = ItemsUI.ItemInput();
                    CoffeeShop.AddItemToMenu(i);
                }
                else if(option == 2)
                {
                    string name = CoffeeShop.CheapestItem();
                    CoffeeShopUI.PrintItems(name);
                }
                else if(option == 4)
                {
                    for (int i = 0; i < CoffeeShop.Menu.Count;i++)
                    {
                       string item =  CoffeeShop.CheckFoodItems(i);
                        if (item != null)
                        {
                            CoffeeShopUI.PrintItems(item);
                          
                        }
                        
                        
                    }
                    
                }
                else if (option == 3)
                {
                    
                    for (int i = 0; i < CoffeeShop.Menu.Count; i++)
                    {
                        string item = CoffeeShop.CheckDrinkItems(i);
                        if (item != null)
                        {
                            CoffeeShopUI.PrintItems(item);
                        }
                        
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("Ennter the order u want to add:");
                    string item = Console.ReadLine();
                    bool exist = CoffeeShop.AddOrder(item);
                    if(exist == true)
                    {
                        CoffeeShop.AddOrdertoList(item);
                    }
                    else
                    {
                        Console.WriteLine("No such item in Menu");
                        
                    }
                }
                else if (option == 6)
                {
                    Console.WriteLine(CoffeeShop.FulfillOrder());
                }
                else if (option == 7)
                {
                    List<string> Orders = CoffeeShop.OrderList();
                    foreach(string i in Orders)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if(option == 8)
                {

                }
                Console.ReadKey();
            }
            while (option != 9);
        }
    }
}
