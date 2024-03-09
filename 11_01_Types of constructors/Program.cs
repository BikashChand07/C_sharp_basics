using System;
using System.Diagnostics.CodeAnalysis;

namespace ConstructorType
{
    /* there are four types of constructors:
    1)default or parameter less constructor
    2)parametrized constructor
    3)Copy constructor
    4)static constructor
    */
    // Default constructors: constructor method without any parameters
    class Consttype{
        int x;
        public Consttype()//defult constructor
        {
            Console.WriteLine("default constructor is called");

        }
        public Consttype(int i)// paramterized constructor
        {
            Console.WriteLine("a parametrized constructor is called.");
            x=i;
        }
        public void Display()
        {
            Console.WriteLine("Value of x is:"+x);
        }
        
    
    static void Main(string[] args)
    { 
        Consttype c1=new Consttype();// a default constructor is called
        Consttype c2=new Consttype(10);// a parametrized construtcor is called
        c2.Display();
        Consttype c3=new Consttype(15);// when a new keyword is used a instance is created and the memory under name c3 is created, which has its own variable x, with value 15
        Consttype c4=new Consttype(20);// a sperate memory under name c4 is created and it has a variable x(with value 20) which is different from varaible of c3(with value 15).

        // so whenever a new instance is created a new seperate copy of memory is created under instance name.
        c3.Display();//Value of x is:15
        c4.Display();//Value of x is:20


    }


    }
    
}
