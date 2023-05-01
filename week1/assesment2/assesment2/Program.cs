using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minOrder ;
            int minAmount ;
            string Customer = "";
            int orderCount = 0;
            Console.WriteLine("Enter minimum number of orders:");
            minOrder =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter minimum amount:");
            minAmount = int.Parse(Console.ReadLine());
            Check(minOrder, minAmount, Customer, orderCount);
        }
        static void Check(int minOrder, int minAmount, string Customer, int orderCount)
        {
            string Order = "";
            int counter = 0;
            string path = "D:\\Assesments\\signUpTask\\customer.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while((record = file.ReadLine()) != null)
                {
                    Customer = parsebyspac(record, 1);
                    orderCount = int.Parse(parsebyspac(record, 2));
                    Order = parsebyspac(record, 3);
                    int count = Order.Length;
                    string temp = "";
                    for (int i = 1; i < count - 1; i++)
                    {
                        temp += Order[i];
                    }
                    string[] array = temp.Split(',');
                    for (int i = 0; i < orderCount; i++)
                    { 
                        int x = int.Parse(array[i]);
                        if(x >= minAmount)
                        {
                            counter++;
                        }
                    }
                    if(counter >= minOrder)
                    {
                        Console.WriteLine(Customer);
                    }
                    
                }
                Console.ReadKey();
            }
        }
        static string parsebyComa(string record, int field)
        {
            int coma = 1;
            string item = "";
            for(int i = 0; i < record.Length; i++)
            {
                if(record[i] == ',')
                {
                    coma++;
                }
                else if(coma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
         
        }
        static string parsebyspac(string record, int field)
        {
            int space = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ' ')
                {
                    space++;
                    continue;
                }
                if (space == field)
                {
                    item = item + record[i];
                }
            }
            return item;

        }
    }
}