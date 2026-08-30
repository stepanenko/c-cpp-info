## .DLL - Dynamic-Link Library. 

It is a file type used in Windows that contains code and data that multiple programs can use at the same time.

What is a DLL?
- **Shared code:** Instead of writing the same code over and over for different apps, developers put it in one DLL file.
- **Saves memory:** Multiple programs can load one DLL file into computer memory at the same time.
- **Updates easily:** You can update a DLL file without changing the programs that use it.

How DLL Relates to C#

- **Compiled output:** When you write code in C# and build your project, C# often compiles your code into a DLL file (or an EXE file).
- **Assemblies:** In C#, a DLL is known as an assembly. It holds the compiled Intermediate Language (IL) code for your classes, methods, and variables.
- **Reusability:** You can write a C# class library, compile it into a DLL, and then use that DLL in other C# programs (or even other languages like VB.NET or C++).
- **References:** To use a C# DLL in a new project, you add it as a "Reference" or a NuGet package, allowing your code to call the functions stored inside it.
- 
