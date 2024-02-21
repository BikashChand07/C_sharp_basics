using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
            
            // int num=23;
            Console.WriteLine(Math.Abs(-20));
            Console.WriteLine(Math.Pow(2,3)); //2^3
            Random rand=new Random();
            int randnum=rand.Next();
            // Console.WriteLine( rand.Next());
            // Console.WriteLine(randnum);
            Console.WriteLine(Math.Round(4.6));// it rounds the number to 5
            Console.WriteLine(Math.Max(13.22,10));
             Console.WriteLine(Math.Min(13.22,10));
              Console.WriteLine(Math.Sqrt(144));
        }
    }
}
