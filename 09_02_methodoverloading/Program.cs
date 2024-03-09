using System;
namespace methodoverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min: "+ Min(4,10));
            Console.WriteLine("Min: "+ Min(5,12));

        }
        static int Min(int n1, int n2)
        {
            if(n1<n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        static double Min(int n1,int n2)
        {
            if(n1<n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
            
        }
        // here both the methods have same signature but different return type . To differentiate the methods not only the return type is sufficient so here compiler gets confused and throw errors. To differentiate the methods there must be consideration of paramters(number,type,order) then the method overloading is possible.
    }
}