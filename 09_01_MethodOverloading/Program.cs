using System;
namespace MethodOverloading
{
    class Program
    {
        // Method Overloading is an approach of defining multiple methods having same name but different behaviours, behaviours of the methods based on the parameters passed on the methods ie the input change will change in output.The input change may be:1)Number of parameters 2) different types of parameters 3) order of parameters
        /*example:
        public void hello()
        public void hello(int i)
        public void hello(string h)
        public void hello(int i, string h)
        public void hello(string h, int i)

        But the return type of method will not consiser ie public string hello() is not valid it will create compile error.
        */
          public void Test(){
            Console.WriteLine("Method 1");
          }
          public void Test(int i){
            Console.WriteLine("Method 2");
          }
          public void Test(string s){
            Console.WriteLine("Method 3");
          }
          public void Test(int i, string s){
            Console.WriteLine("Method 4");
          }
          public void Test(string s, int i){
            Console.WriteLine("Method 5");
          }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.Test();
            p.Test(12,"ska");
            p.Test(1);
            p.Test("snbs");
            p.Test("snbs",12);

            
        }
    }
}
