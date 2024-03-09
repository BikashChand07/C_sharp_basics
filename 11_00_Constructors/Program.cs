using System;

namespace Constructors
{
    class Constructexample{
        public string title;
        public string author;
        public string price;
        // constructor 
        public Constructexample(string tit,string auth,string pric)
        {
            title=tit;
            author=auth;
            price=pric;
        }
        public  void Displayinfo()
        {
            Console.WriteLine("Title: "+title+"\nAuthor: "+author+"\nPrice: "+price);

        }


    }
    class Program{
        static void Main(string[] args)
        {
            /* 
            -constructors are the special methods which are used to initialized the objects.
            -constructors are automatically called when the object is created.
            -the name of the constructor and class should be same.
            -Constructor doesnt have return type(like int or void)
            -All classes have constructors by default. if you donot create the constructors the c# will create a constructor by default and at that case you are not allowed to set the values.
            -Constructors can also have parameters.
            */ 
            Constructexample co=new Constructexample("Flying Dust","Mr fungsuk Wangdu","1200");
            co.Displayinfo();
            
        }
    }
}
