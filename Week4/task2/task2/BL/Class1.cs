using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class Book
    {
        public string title;
        public string auther;
        public int pages;
        public List<string> Chapters = new List<string>();
        public int bookMark;
        public int price;
        public Book(string title, string auther, int pages, List<string> Chapters, int bookMark, int price)
        {
            this.title = title;
            this.auther = auther;
            this.pages = pages;
            this.Chapters = Chapters;
            this.bookMark = bookMark;
            this.price = price;


        }
        public string GetChapter(int number)
        {
            for(int i = 0; i < Chapters.Count; i++)
            {
                if(number == i)
                {
                    return Chapters[i];
                }
            }
            return "no chapter";
        }
        public int GetBookMark()
        {
            return bookMark;
        }
        public void setBookMark(int number)
        {
            this.bookMark = number;
        }
        public int GetPrice()
        {
            return price;
        
        }
        public void SetBookPrice(int price)
        {
            this.price = price;
        }
    }
}
