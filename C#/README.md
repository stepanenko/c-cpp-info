
# C#

As of November 2022, the most recent stable version of the language is C# 11.0, which was released in 2022 in .NET 7.0.

C# was designed by **Anders Hejlsberg** (Microsoft) and developed by **Mads Torgersen** (Microsoft) in **2000**.

The name "C sharp" was inspired by the musical notation whereby a sharp symbol indicates that the written note should be made a semitone higher in pitch. This is similar to the language name of C++, where "++" indicates that a variable should be incremented by 1 after being evaluated. The sharp symbol also resembles a ligature of four "+" symbols, further implying that the language is an increment of C++.

C# is a modern **general-purpose, multi-paradigm language: structured, imperative, object-oriented, event-driven, task-driven, functional, generic, reflective, concurrent**.

C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.

C# enables developers to build many types of secure and robust applications that run in .NET.

C# has its roots in the C family of languages and will be immediately familiar to **C, C++, Java, and JavaScript** programmers.

C# takes some of the useful features of C and adds syntax to save time and effort. Although C# is based on C, you can learn it without any knowledge of C.

### Tutorials:

- [C# Basics for Beginners: Learn C# Fundamentals by Coding (Mosh)](https://coursehunter.net/course/osnovy-c-dlya-nachinayushchih-izuchenie-osnov-c-na-praktike)

- [C# Intermediate: Classes, Interfaces and OOP (Mosh)](https://coursehunter.net/course/c-intermediate-klassy-interfeysy-i-oop)

- [Advanced data structures and algorithms in C# (Mosh)](https://coursehunter.net/course/udemy-adv-csharp)

- [How to Run C# in VSCode (Compile, Debug, and Create a Project)](https://www.youtube.com/watch?v=DAsyjpqhDp4&ab_channel=TravisMedia)

## Constructors:

```cs
public class Customer
{
    public string Name;
    
    public Customer(string name) // constructor method
    {
        this.Name = name;
    }
}

// usage
var customer = new Customer("Serhiy");
```

### Constructor Overloading:
```cs
public class Customer
{
    public Customer() { ... } // constructor 1
    public Customer(string name) { ... } // constructor 2
    public Customer(int id, string name) { ... } // constructor 3
}
// here we say Customer constructor is overloaded with 2 more constructors, and we may use whichever we need
```
