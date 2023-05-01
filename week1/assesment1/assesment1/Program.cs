using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void task1()
        {
            Console.Write("Hello World!");
            Console.Write("Hello World!");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");
            Console.ReadKey();
        }
        static void task3()
        {
            int number = 10;
            Console.WriteLine("Number :");
            Console.Write(number);
            Console.ReadKey();
        }
        static void task4()
        {
            string line = "I am Maryam Waseem";
            Console.WriteLine("The string is:");
            Console.Write(line);
            Console.Read();
        }
        static void task5()
        {
            char character  = 'M';
            Console.WriteLine("The letter is:");
            Console.Write(character);
            Console.Read();
        }
        static void task6()
        {
            float number = 2.4F;
            Console.WriteLine("The floating point number is:");
            Console.Write(number);
            Console.Read();
        }
        static void task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You enterd this string:" + str);
            Console.ReadKey();
        }

        static void task8()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            Console.Write("You entered the number:" + number);
            Console.ReadKey();
        }
        static void task9()
        {
            int length;
            int area;
            length = int.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("The Area is :" + area);
            Console.ReadKey();
        }
        static void task10()
        {
            int marks;
            marks = int.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.WriteLine("You are passed!");
            }
            else
            {
                Console.WriteLine("you are failed!");
            }
            Console.ReadKey();
        }
        static void task11()
        {
            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("welcome Maryam!");
            }
            Console.ReadKey();
        }
        static void task12()
        {
            int number;
            int sum = 0;
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            while(number != -1)
            {
                sum = sum + number;
                Console.Write("Enter number:");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Total sum iss:" + sum);
            Console.ReadKey();
        }
        static void task13()
        {
            int[] number = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number:");
                number[i] = int.Parse(Console.ReadLine());
            }
            int largest = -1;
            for(int i = 0; i < 3; i++)
            {
                if(number[i] > largest)
                {
                    largest = number[i];
                }
            }
            Console.WriteLine("Largest number is:" + largest);
            Console.ReadKey();
        }


    }
   
}
