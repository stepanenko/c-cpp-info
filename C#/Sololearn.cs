// redesign the given method so that it will take the given input
// as the name of the user and output the welcome message with it

using System;

public class Program
{
    static void Main(string[] args)
    {
        Welcome();   
    }

    static void Welcome()
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome, {name}!");
    }
}
