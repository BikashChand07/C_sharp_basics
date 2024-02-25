using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Array is used to hold multiple data under single varibale
           // syntax for declaring array:  datatype[] arrayname={values};
           string[] names={"Bikash","Bibek","mohit"};
           Console.WriteLine("The size of array is:{0}",names.Length);

           //accessing array elements
           Console.WriteLine("The array elements are:");
           for(int i=0;i<names.Length;i++)
           {
           Console.WriteLine(names[i]);
           }

           // there are many ways to create arrays:
           /*
           Create an array of four elements, and add values later
             string[] cars = new string[4];

              Create an array of four elements and add values right away 
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

             Create an array of four elements without specifying the size 
             string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

            Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            // Add values without using new (this will cause an error)
            cars = {"Volvo", "BMW", "Ford"};
        

            int[] num={12,33,22,11,10}
        
             or
             int[] num;
             num= new int[]{12,22,33,22};
             */

        int[] num={12,23,10,30};
        Console.WriteLine(num[2]);

        int[] num1= new int[4] {12,22,33,33};
        Console.WriteLine(num1[3]);
    
    // without specifying size
    int[] num2= new int[] {1,2,3,4,5,6,7,8,9,10};
    Console.WriteLine(num2[9]);

    //sort array
    int[] numbers={12,3,4,22,45,65,90,10,88,999};
    Array.Sort(numbers);
    foreach(int i in numbers)
    {
        Console.WriteLine(i);
    }

       
        }
    }
}
