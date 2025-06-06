
# C#

**C#** was designed in 2000 by **Anders Hejlsberg** (Microsoft) and developed by **Mads Torgersen** (Microsoft).

**Anders Hejlsberg** is a Danish software engineer also known for his work on other programming languages, such as Turbo Pascal and Delphi.

**C#** was developed by **Hejlsberg** and his team at Microsoft as part of the **.NET Framework**. It was first released in **2000** as part of **.NET Framework 1.0**, with the goal of providing a modern, object-oriented programming language that could be used for building a wide range of applications, including Windows applications, web services, and more.

**C#** was designed to be a **simple, powerful, and type-safe language** that could address many of the shortcomings of earlier programming languages

The most recent stable version of the language is **C# 13 released in 2024 alongside .NET 9** (released in November 2024). 
The current long-term support (LTS) version is .NET 8, released in November 2023, which will receive updates until November 2026.

A new version of the C# is released every year.

C# 13 is supported only on .NET 9 and newer versions. C# 12 is supported only on .NET 8 and newer versions. C# 11 is supported only on .NET 7 and newer versions. C# 10 is supported only on .NET 6 and newer versions.

The name "C sharp" was inspired by the musical notation whereby a sharp symbol indicates that the written note should be made a semitone higher in pitch. This is similar to the language name of C++, where "++" indicates that a variable should be incremented by 1 after being evaluated. The sharp symbol also resembles a ligature of four "+" symbols, further implying that the language is an increment of C++.

C# is a modern **general-purpose, multi-paradigm language: structured, imperative, object-oriented, event-driven, task-driven, functional, generic, reflective, concurrent**.

C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines.

C# has its roots in the C family of languages and will be immediately familiar to **C, C++, Java, and JavaScript** programmers.

C# takes some of the useful features of C and adds syntax to save time and effort. Although C# is based on C, you can learn it without any knowledge of C.

C# programs run on .NET, a virtual execution system called the common language runtime (CLR) and a set of class libraries. Source code written in C# is compiled into an intermediate language (IL). The IL code and resources, such as bitmaps and strings, are stored in an assembly, typically with an extension of `.dll`.

When the C# program is executed, the assembly is loaded into the CLR. The CLR performs Just-In-Time (JIT) compilation to convert the IL code to native machine instructions.

"Hello World" written in C#:
```cs
using System;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World"); // This line prints "Hello, World" 
    }
}
```
To run/edit the code or read about C# program basics go to - https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/#hello-world

### Tutorials:

- [Official C# for Beginners Videos](https://learn.microsoft.com/en-us/shows/csharp-for-beginners/)

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

### App Settings (`appsettings.json`)
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Information"
    }
  },
  ...
}
```
`"Default"` - Sets the minimum log level for your entire app  
`"Microsoft.AspNetCore"` - Specifically sets the logging level for ASP.NET Core framework messages (e.g., HTTP pipeline, routing, middleware)

Common log levels in order of verbosity:

`Trace`	- Super-detailed logs (low-level debug)  
`Debug`	- Debugging info  
`Information` - Normal events (requests, startup info)  
`Warning` - Something odd but not breaking  
`Error` - Something failed  
`Critical` - Serious error, app might crash  
`None` - Turn off logging  

For production, consider changing these settings to be less verbose.
