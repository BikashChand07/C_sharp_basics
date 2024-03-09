using System;
namespace Inheritance{
    class Program{
        static void Main(string[] args)
        {
            Dog dg=new Dog();
            dg.bark();//own properties
            dg.eat();//accessing the properties of parent class(Animal)using child class object

            Babydog bd=new Babydog();
            bd.bark();// accessing the parent class(Dog) properties using child class object(Babydog bd)
            bd.eat();//accesssing the properties of parent of parent class(Animal) using child class object .for parent Animal the Babydog class is grandchild
            bd.weep();//own properties
        }
    }
    //single level inheritance
    public class Animal//parent class
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
       
    }
    public class Dog:Animal// child class=dog and parent class is Animal
    {
         public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    //Multilevel Inheritance
    public class Babydog:Dog// here class Dog is the parent for the child class Babydog 
    {
        public void weep()
        {
            Console.WriteLine("weeping...");
        }

    }

}

