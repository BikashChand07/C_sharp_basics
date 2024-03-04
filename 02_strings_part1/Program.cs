using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name="Hello Bikash";
            //  Console.WriteLine(name +" Chand");
            // string methods

            Console.WriteLine(name.Length);
            Console.WriteLine(name[0]);
            Console.WriteLine(name.Contains("Bikash"));// it checks if name contains the string bikash or not. it returns either true or false
            Console.WriteLine(name.Contains("Chand"));// returns false
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Substring(6));// it returns the string from index 6 to last. it returns the string Bikash
            Console.WriteLine(name.Substring(6,3));//it returns the string between index 6 and 2 more string from index 6 ie it returns Bik 
            Console.WriteLine(name.IndexOf("Bikash"));//it returns the index of B ie 6
            Console.WriteLine(name.IndexOf("e")); //it returns the value 1 ie index of e
            Console.WriteLine(name.Substring(name.IndexOf("i")));// first it gets the index of i and then it returns the substring between the index of i and last index ie  it returns ikash

        }
    }
}