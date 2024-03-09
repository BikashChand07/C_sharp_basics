using System;
namespace Inheritance
{
    // parent classes constructor will accessible to child class, otherwise the inheritance will not be possible. that is whenever the child class instances is created the child class constructor will implicitly called the parent classes constructor.
    class Parent
    {
        public Parent()// parent class constructor
        {
            Console.WriteLine("parent class constructor is called");
        }
    }
    class Child:Parent{
        static void Main(string[] args)
        {
        Child c=new Child();// here the instance of the child class is created
        // when this instance is created the child class constructor(implicit) will call the parent class constructor.
        }

    }

  
}
