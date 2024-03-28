using System;
using System.Diagnostics.Contracts;

namespace Inheritance_Concept
{
    //      As we learnt whenever the child class instance is created , the child class constructor will implicitly call its parent class conctrutor but only if the constructor is parameterless. problem: where as if the constructor of parent class is parameterized ,child class constructor cannot implicitly call its parent class constructor(parameterized).

    //     class Class1 //parent class
    //     {
    //         public Class1(int i)// parent class parameterized constructor
    //         {
    //             Console.WriteLine("parent class constructor is called with value :",i);
    //         }
    //     }
    // class Class2 : Class1  // base class
    //     {
    //         public Class2()
    //         {
    //             Console.WriteLine("class 2 constructor is called");
    //         }
    //         static void Main(string[] args)
    //         {
    //            Class2 c= new Class2(); 
    //         }
    //     }

    // so to overcome this problem we explicitly call the parent class parameterized constructor by child class parameterless constructror using base keyword.

    class Class1 //parent class
    {
        public Class1(int i)// parent class parameterized constructor
        {
        Console.WriteLine("parent class constructor is called with value : "+i);
        }
    }
    class Class2 : Class1  // base class
    {
        public Class2():base(10)// this base(10) refers to the parent class paramterized contsructor and pass the value 10 to the i.
        {
            Console.WriteLine("class 2 constructor is called");
        }
        static void Main(string[] args)
        {
            Class2 c = new Class2();
        }
    }
}
