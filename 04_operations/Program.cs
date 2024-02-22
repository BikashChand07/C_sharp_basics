using System;
namespace operations
{
    class Program{
        static void Main(string[] args)
        {
            int addition,subtraction,division,mul,num1,num2;
            Console.WriteLine("Enter the number One:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number two:");
            num2=Convert.ToInt32(Console.ReadLine());
            addition=num1+num2;
            subtraction=num1-num2;
            mul=num1*num2;
            division=num1/num2;
            // Console.WriteLine("The addition is: {0}",addition);
            // Console.WriteLine("The subtraction is: "+subtraction);
            // Console.WriteLine("The multiplication is: "+mul);
            // Console.WriteLine("The division is: "+division);
            Console.WriteLine("The addition is: "+ addition +"\nThe subtarction is: " + subtraction + "\nThe multiplication is: " + mul + "\nThe division is:"+division);
        }
    }
}