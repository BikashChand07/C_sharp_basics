using System;
// varaibles are like a container which holds the value 
//datatypes represent the types of data or variables such as int represent the integer type, bool represents the boolean type(either true or false),float represent the decimal value similarly there are other datatypes such as string,double,decimal etc
string name = "Bikash Chand";
int age = 21;
double marks = 55.3;


Console.WriteLine("hello this is me " + name);

Console.WriteLine("Age:" + age);
Console.WriteLine("Marks:" + marks);


// Getting user inputs

// console.writeline() prints something on the screen
// Console.ReadLine() gets the value that prints on screen so we use this command to get the inputs and store them in some variables.

Console.WriteLine("Enter your name: ");
string Name = Console.ReadLine();
Console.WriteLine("Enter your Age:");
int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Your name: " + Name);
Console.WriteLine("Your age:" + Age);
