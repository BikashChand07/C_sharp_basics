using System;
using System.Text;
using System.Diagnostics;// for using stopwatch class
namespace stringperformance{
    class Program{
        static void Main(string[] args)
        {
            // for immutable:
            // here loop runs for one lakh times and every time we perform modification ie concatenation and every time a new copy is created with modification therfore there are onelakh+1 copies (1 for original one).
        
            string s="";
            Stopwatch sw1=new Stopwatch();
            sw1.Start();
            for(int i=1;i<100000;i++)
            {
                s=s+i;
            }
            sw1.Stop();
            Console.WriteLine("Time taken for String Class ie immutable string is :"+sw1.ElapsedMilliseconds);// it takes 11437 milli seconds

            // mutable :
            // Modification(ie append) is done at only one copy(original) at every iteration of loop.ie No multiple creation of copies on every iteration of loop.
            StringBuilder sb=new StringBuilder();
            Stopwatch sw2=new Stopwatch();
            sw2.Start();
            for(int i=1;i<100000;i++)
            {
                sb=sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time taken for StringBuilder Class ie mutable string is :"+sw2.ElapsedMilliseconds);//: it takes 2milliseconds

            // since SetBuilder class takes less time than String class therfore we conclude that StringBuilder is more efficient than String Class. 
        }
    }
}
