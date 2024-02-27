using System;
namespace loop
{
    class Program{
        static void Main(string[] args)
        {

        // //for loop
        //  Console.WriteLine("The even numbers betweeen 0 to 100 are:");
        // for(int i=0;i<=100;i++)
        // {
        //     if(i%2==0) Console.WriteLine(i);
           
        // }

        // //while loop 
        // Console.WriteLine("The odd numbers betweeen 0 to 100 are:");
        // int j=1;
        // while(j<100)
        // {
        //     if(j%2!=0) Console.WriteLine(j);
        //     j++;
        // }
        
        // multiplication table
        int num;
        Console.WriteLine("enter the number:");
        num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The multiplication table of {0} is:",num);
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(num+"*"+i+"="+num*i);

        }


        //foreach loop
        // syntax: foreach(datatype newvariable in arrayname)
        
         string[] sixthsemheros={"Bhim","Bikash","Laxman","Bibek","Mohit"};
        Console.WriteLine("The new heroes of SNSC are:");
        foreach(string hero in sixthsemheros)
        {
            Console.WriteLine(hero);
        }
    }
    }
}