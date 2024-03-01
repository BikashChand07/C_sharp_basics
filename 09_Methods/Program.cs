using System;
namespace MethodsInCsharp
{
    class Program
    {
        static void Print()
        {
            Console.WriteLine("hello world C#");
        }
        static int Sum(int x,int y)
        {
            return x+y;
        }
        static void PrintName(string fname,string lname)
        {
            Console.WriteLine("My name is "+fname+" "+lname);
        }
        
        static void Main(string[] args)
        {
            //sometimes Methods are also called Functions .Methods are the block of code which is used when there is a need of use of same code several times in  a program.
            //In Main function the function is called but the function is defined outside the main function.
            
            Print();
            Console.WriteLine(Sum(4,6));
             PrintName("Bibek","Chataut");
        }
    }
}
