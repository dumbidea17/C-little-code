/*
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// classes are containers that store your code
// only one public class within a c# file
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
        // object: the thing you make from a class
        Dog objDog = new Dog("RANGER", 14);
        Console.Write(objDog.toString());
        Console.WriteLine(objDog.toInt());
    }
}

// class: a container that's used as a blueprint to make multiple copies of something (clones)
class Dog{
    String name; // before the name, include the data type of the variable you're creating
    int age;
    // constructors: method that initializes the basics attributes of a class
    public Dog(String name, int age){
        this.name = name;
        this.age = age;
    }
    
    public String toString()
    {
        return "This dog's name is " + this.name;
    }
    public int toInt()
    {
        return this.age;
    }   
    
}
*/