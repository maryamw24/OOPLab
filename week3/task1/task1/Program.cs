using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.clock.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default Constructor
            Class1 empty_time = new Class1();
            Console.WriteLine("Empty time:");
            empty_time.PrintTime();
            // Parameterized Constructor (onr paramenter)
            Class1 hour_time = new Class1(8);
            Console.WriteLine("hour time:");
            hour_time.PrintTime();
            // Parameterized Constructor (two prameter)
            Class1 minute_time = new Class1(8,10);
            Console.WriteLine("minute time:");
            hour_time.PrintTime();
            // Parameterized Constructor (three perameters)
            Class1 Full_time = new Class1(8,10,10);
            Console.WriteLine("Full time:");
            Full_time.PrintTime();
            // increment Second
            Full_time.increaseSecond();
            Console.WriteLine("Full time(increase second):");
            Full_time.PrintTime();
            // increment Second
            Full_time.increaseMinutes();
            Console.WriteLine("Full time(increase minutes):");
            Full_time.PrintTime();
            // increment Second
            Full_time.increaseHours();
            Console.WriteLine("Full time(increase hours):");
            Full_time.PrintTime();
            // check if equal
            bool flag = Full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag " + flag);
            // check if equal to object
            Class1 temp = new Class1(10, 12, 1);
            flag = Full_time.isEqual(temp);
            Console.WriteLine(" Object Flag " + flag);
            // elapsed time
            Class1 time = new Class1(24, 0, 0);
            time.ElapsedTime();
            time.PrintTime();
            int seconds = (time.hours * 3600 + time.minutes * 60 + time.seconds);
            Console.WriteLine("time on seconds:" + seconds);
            time.PrintTime();
            Console.ReadKey();
            // remaining time
            time.RemainingTime(time);
            int second = (time.hours * 3600 + time.minutes * 60 + time.seconds);
            Console.WriteLine("time on seconds:" + second);
            // difference
            Class1 time1 = new Class1(12, 30, 0);
            Class1 time2 = new Class1(11, 15, 0);
            time1.Difference(time1, time2);
            Console.ReadKey();
        }
    }
}
