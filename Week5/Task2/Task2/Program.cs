using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.UI;
using Task2.BL;
using Task2.DL;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
            Console.Clear();
            option = UserUI.MainMenu();
                if(option == 1)
                {
                    Console.Clear();
                    User u = UserUI.SignUpInput();
                    UserDL.AddUserToList(u);
                }
                else if(option == 2)
                {
                    Console.Clear();
                    User u1 = UserUI.SignInInput();
                    User u2 = UserDL.SignIn(u1);
                    if(u2 != null)
                    {
                        if(u2.GetRole()== "Owner" || u2.GetRole() == "owner")
                        {

                        }
                        else if(u2.GetRole() == "Customer" || u2.GetRole() == "customer")
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect UserName or Password!");
                    }
                    
                }
                Console.ReadKey();

            }
            while (option < 3);
            
        }
    }
}
