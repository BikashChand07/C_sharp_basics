using System;
using System.Dynamic;
using System.Text;
namespace strings
{
    class Program{
        static void Main(string[] args)
        {
            /* strings are of two types:
             1)Immutable: strings whose content cannot be modified after the string has been created.hence changing content will lead to the creation of a new String ie every time when you want to create some modification the real one string exist along with the new string after modification will also exist. it means a new copy or memory is created whenever you modified the content of string but actually the real string is not modified.
             
             2)Mutable:strings which can be modified.

             For immutable string String Class is used.To use String class we use System namepace which contains the String class. whenever the modification is done to the string a seperate new copy is created with modification without affect the original one.
             if there is n number of modification then the n+1 number of copies are made.this is the disadvantage of immutable string.
             But this immutable string is used for security purpose

             For mutable string StringBuilder class is used.To use StringBuilder class we use System.Text namespace. there is no any creation of a new copy whenever the modification is done. rather than the modification is done on the original one or on the same copy the modification is done.
            
             */

             //immutable string:

             string str="Hello";// here the one memory location store string hello and str points to that location ie Hello

             str = str+" World program.";// here we modified the string hello .actually the original string remains same and the new copy is created which contains modified string ie Hello world.therfore two memory space is created first for Hello and second for Hello World program.Now str reference or points to Hello world program
             
             str = str+"Thank you";//again here we modified the string str,the str points to the string "Hello World Program" . when this modification is done the new copy is created which contains string "Hello World program.Thanky you" and after that the str points to the string "Hello World program.Thanky you".Therfore three copy is made when there is only  two modification is done to the string. 
             
             Console.WriteLine(str);

             // Mutable string
             StringBuilder st=new StringBuilder();//it creates a empty string called st;
             StringBuilder st1=new StringBuilder("hello");//it creates a string str1 which contains hello

             st = st.Append(st1);// dont use conacate operator to append the string
             Console.WriteLine(st);

             

             

        }
    }
}
