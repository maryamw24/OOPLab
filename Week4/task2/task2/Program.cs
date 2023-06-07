using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        static void task2()
        {
            List<string> Chapters = new List<string>();
            Chapters.Add("1");
            Chapters.Add("2");
            Book info = new Book("my", "maryam", 200, Chapters, 30, 1000);
            Console.WriteLine("Chapter:" + info.GetChapter(0));
            Console.WriteLine("BookMark:" + info.GetBookMark());
            Console.WriteLine("Price:" + info.GetPrice());
            info.setBookMark(20);
            info.SetBookPrice(1500);
            Console.WriteLine("BookMark:" + info.GetBookMark());
            Console.WriteLine("Price:" + info.GetPrice());
            Console.ReadKey();

        }
    }
}
