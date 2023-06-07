using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DL;

namespace Task1.BL
{
    class CoffeeShop
    {
        public string Name;
        public static List<Items> Menu = new List<Items>();
        public static List<string> Orders = new List<string>();
        public static void AddItemToMenu(Items i)
        {
            Menu.Add(i);
        }
        public static void AddOrdertoList(string order)
        {
            Orders.Add(order);
        }
        public static string CheapestItem()
        {
            int cheapestPrice = Menu[0].price;
            string cheapestProduct = Menu[0].name;
            for(int i = 0; i < Menu.Count; i++)
            {
                if(Menu[i].price < cheapestPrice )
                {
                    cheapestPrice = Menu[i].price;
                    cheapestProduct = Menu[i].name;
                }
            }
            return cheapestProduct;

        }
        public static bool AddOrder(string Name)
        {
            bool flag = false;
            foreach (Items i in Menu)
            {
                if (Name == i.name)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public static string FulfillOrder()
        {
            bool flag = false;
            for(int i = 0; i < Orders.Count; i++)
            {
                if(Orders[i] != null)
                {
                    string order = Orders[i];
                    Orders.RemoveAt(i);
                    return "Your " + order+ " is ready.";
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if(flag == false)
            {
                return "All Orders are fullfilled";
            }
            return "All Orders are fullfilled";
        }
        public static List<string> OrderList()
        {
            return Orders;
        }
        public static string CheckFoodItems(int i)
        {
           

                if(Menu[i].type == "Food" || Menu[i].type == "food")
                {
                    return Menu[i].name;
                   
                }
            return null;
            
        }
        public static string CheckDrinkItems(int i)
        {
            

            if (Menu[i].type == "Drink" || Menu[i].type == "drink")
            {
                return Menu[i].name;
              
            }
            return null;

        }

    }
}
