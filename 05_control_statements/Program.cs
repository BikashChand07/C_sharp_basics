using System;
namespace conditional_Statements
{
    class Program{
        static void Main(string[] args)
        {
            //if,if-else,if-elseif
        //    int num1;
        //    int i;
        //    int count=0;
        //     Console.WriteLine("Enter the number One:");
        //     num1=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter the number two:");
            // num2=Convert.ToInt32(Console.ReadLine());
            
            //checked even  or odd 
            //if(num1 % 2==0)
            //  {
            //     Console.WriteLine("The number is even");
            //  }
            //  else{
            //     Console.WriteLine("The number is odd");
            //  }
            

            //check primenumber or not
            // for(i=1;i<=num1;i++)
            // {
            //     if(num1%i==0)
            //     {
            //         count++;
            //     }
            // }
            // if(count==2)
            // {
            //     Console.WriteLine("The " +num1+ " is prime Number");
            // }
            // else
            // {
            //     Console.WriteLine("The "+num1+" is  not prime Number");
            // }

            //if else if ladder

               int marks;
            Console.WriteLine("enter your marks:");
            marks=Convert.ToInt32(Console.ReadLine());

            if(marks>100 && marks<0)
            {
                Console.WriteLine("your marks should be less than 100 and greater than 0 ");
            }
            else if(marks<=40)
            {
                Console.WriteLine("Fail!");
            }
            else if(marks>40 && marks<=50)
            {
                Console.WriteLine("C Grade");
            }
            else if(marks>50 && marks<=60)
            {
                  Console.WriteLine("C+ Grade");
            }
             else if(marks>60 && marks<=70)
            {
                  Console.WriteLine("B Garde");
            }
             else if(marks>70&& marks<=80)
            {
                  Console.WriteLine("B+ Grade");
            }
             else if(marks>80 && marks<=90)
            {
                  Console.WriteLine("A Grade");
            }
             else if(marks>90 && marks<=100)
            {
                  Console.WriteLine("A+ Grade");
            }
        }
    }
}
