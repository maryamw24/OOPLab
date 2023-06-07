using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BL;

namespace Task2.UI
{
    class UserUI
    {
        public static int MainMenu()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("1.SignUp");
            Console.WriteLine("2.SignIn");
            Console.WriteLine("3.Exit");
            Console.Write("Enter your choice:");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static User SignUpInput()
        {
            Console.WriteLine("Enter your UserName:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string Password = Console.ReadLine();
            Console.WriteLine("Enter your Role(Customer/ Owner):");
            string Role = Console.ReadLine();
            User u = new User(UserName, Password, Role);
            return u;
        }
        public static User SignInInput()
        {
            Console.WriteLine("Enter your UserName:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            if (username != null && password != null)
            {
                User info = new User(username, password);
                return info;
            }
            return null;
        }
        public static int menu()
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
        
    }
}
