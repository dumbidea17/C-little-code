// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// classes are containers that store your code
public class HelloWorld
{
    // function == method
    // tester method-> allows you to write and see code on the output/console
    public static void Main(string[] args)
    {
        // strings: anything surrounded by quotation marks- the equivalent of text in C#
        Console.WriteLine ("Try programiz.pro"); // this is a print statement
        Console.WriteLine ("Daiki Panjanon");
        Console.WriteLine ("14");
        Console.WriteLine ("sleeping");
        
        // integers: whole numbers in C#
        Console.WriteLine(2);
        
        Console.WriteLine(2764 * 2);
        // string concatenation: combining strings to create a bigger string
        Console.WriteLine ("run" + "ing");
        Console.Write("bananananana ");
        Console.Write("is good ");
        Console.Write("yes ");
        Console.Write("bananananana\n");
        Dog dog1 = new Dog("Robert");
    }
}


class Dog{
    String name;
    // constructors: method that initializes the basics attributes of a class
    public Dog(String name ){
        this.name = name;
    }
}
