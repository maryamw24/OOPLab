using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using task3.UserData.BL;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOPLab\\task3\\Users.txt";
            string UserName;
            string Password;
            Class1[] Users = new Class1[10];
            int count = 0;
            while(true)
            {
                int choice = menu();
                if(choice == 1)
                {
                    Console.WriteLine("Enter your userName:");
                    UserName = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    Password = Console.ReadLine();
                    bool valid = IsValid(UserName, count, Users);
                    if(valid == true)
                    {
                        AddUser(UserName, Password, Users,ref count);
                        signUp(path, UserName, Password);
                    }
                    else
                    {
                        Console.WriteLine("UserName Already exist!!");
                        Console.WriteLine("Try with another userName!");
                        Console.ReadKey();
                    }
                }
                if(choice == 2)
                {
                    Console.WriteLine("Enter your userName:");
                    UserName = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    Password = Console.ReadLine();
                    signIn(UserName, Password, Users);
                }


            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignUp");
            Console.WriteLine("2. Signin");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void readData(Class1[] Users, ref int count)
        {
            string path = "D:\\OOPLab\\task3\\Users.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Users[count].UserName = parseData(record, 1);
                    Users[count].Password = parseData(record, 2);
                    count++;
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void signIn(string n, string p, Class1[] Users)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == Users[x].UserName && p == Users[x].Password)
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void AddUser(string Username, string Password, Class1[] Users, ref int count)
        {
            Users[count].UserName = Username;
            Users[count].Password = Password;
            count++;
        }
        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
        static bool IsValid(string username, int userCount, Class1[] Users)
        {
            bool flag = true;
            for (int i = 0; i < userCount; i++)
            {
                if (username == Users[i].UserName)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

    

