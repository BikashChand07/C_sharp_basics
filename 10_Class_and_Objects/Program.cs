using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Book bk=new Book();
          bk.setTitle("python Book");
          bk.setauthor("Bikash Chand");
          bk.setprice("100000");
          bk.printBook(); 
        }
        
    }
    class Book
    {
        private string title;
        private string price;
        private string author;
        public void setTitle(string tit)
        {
            title=tit;
        }
        public void setprice(string pric)
        {
            price=pric;
        }
        public void setauthor(string auth)
        {
            author=auth;
        }
        public void printBook()
        {
            Console.WriteLine("The title of the book: "+title+",written by "+author+" and co writer Mahesh joshi. The price of the book is $"+price);
        }
    }
    
}
