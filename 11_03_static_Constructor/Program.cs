using System;
namespace StaticConstructorExample
{
    class Staticconstructor
    {
        /*
        static constructor: 
        1)These constructors are defined using static modifier.eg static nameof constructor(){}
        2)If a class conatins the static varaibles the static constructors are used to initialize the static variables. and in case of static varaibles the implicit static constructors are present or else we need to define them explicitly.
        3) the non static constructors are implicitly defined in every class except static class provided that we didnt define them explicitly.
        4)these static constructors are never called explicitly but they are called implicitly .
        5)these constructors are first to execute under any class. ie in main program first the static constructor is executes then the remaining code of main program executes.
        6) static constructors are parameter less . therfore they cannot be overloaded.
        */
        //example:
        
         static Staticconstructor()
         {
            Console.WriteLine("Static Constructor is executed");
         }

        static void Main(string[] args)
        {
            //without writing any code in main program if we run this program the static constructor is executed because the static constructor are executes first before any code of the main program. 
        Console.WriteLine("hello world");
        /*output:
        Static Constructor is executed
        hello world
        */


        }
    }
}
