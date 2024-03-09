using System;
using System.Runtime.CompilerServices;
namespace Copyconstructorexample
{
    class Copyconstructor
    {
        //copy constructor: it is used when we want to create multiple instance with same values.

        /*suppose copyconstructor c1=new copyconstructor(12); . it will create a instance with value 12 . again if we want to create another instance with same value we just pass the same parameter like this:copyconstructor c2=new copyconstructor(12);

        This will be fine when the  number of values are less. what if the number of values are large then we use the copy constructor in that case we just pass the same class as a parameter to the constructor. if we do this then we dont need to pass the same values . we just pass the instance from where we take the values. 
        */
        int x;
        public Copyconstructor(int i)// parameterized constructor
        {
            x=i;
        }
        public Copyconstructor(Copyconstructor obj)//Copy constructor
        {
            x=obj.x;
        }

        public void Display()
        {
            Console.WriteLine("x= "+x);
        }

        static void Main(string[] args)
        {
            Copyconstructor c1=new Copyconstructor(12);
            Copyconstructor c2=new Copyconstructor(c1);// here we pass the instance rather than passing the same parameters of c1 instance.
            c1.Display();
            c2.Display();


        }
    }
}
