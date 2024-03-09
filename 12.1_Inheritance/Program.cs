using System;
namespace inheritance{
    class Program{
        static void Main(string[] args)
        {
            manager mg= new manager( "Bikash Chand",30);
            mg.findsalary();
              
        }
    }
     public class employee{
        public string empname;
        public double workeddays;
        }

     
     public class manager:employee
     {
        public int feeperday=500;

        //constructor
         public manager(string employeename,double workday)
        {
        empname=employeename;
        workeddays=workday;
        }
        public void findsalary()
        {
            Console.WriteLine(empname+" your salary is:"+(workeddays*feeperday));
            }
     }
} 