# Data Types in C#

C# provides a variety of data types to handle different kinds of data. These can be broadly categorized into **value types** and **reference types**. Below is an overview of the main data types in C#.

## Value Types
Value types store the actual data directly in memory and are typically allocated on the stack. They include:

### 1. Integer Types (Whole Numbers)
- `sbyte`: 8-bit signed integer (-128 to 127)
- `byte`: 8-bit unsigned integer (0 to 255)
- `short`: 16-bit signed integer (-32,768 to 32,767)
- `ushort`: 16-bit unsigned integer (0 to 65,535)
- `int`: 32-bit signed integer (-2,147,483,648 to 2,147,483,647)
- `uint`: 32-bit unsigned integer (0 to 4,294,967,295)
- `long`: 64-bit signed integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
- `ulong`: 64-bit unsigned integer (0 to 18,446,744,073,709,551,615)

### 2. Floating-Point Types (Decimal Numbers)
- `float`: 32-bit single-precision floating-point (±1.5e−45 to ±3.4e38, ~6-9 digits precision)
- `double`: 64-bit double-precision floating-point (±5.0e−324 to ±1.7e308, ~15-17 digits precision)
- `decimal`: 128-bit high-precision decimal (±1.0e−28 to ±7.9e28, 28-29 digits precision, ideal for financial calculations)

### 3. Boolean Type
- `bool`: Represents `true` or `false`

### 4. Character Type
- `char`: 16-bit Unicode character (e.g., 'A', '\u0041')

### 5. Structs
- Custom value types defined using the `struct` keyword (e.g., `Point { int x, y; }`)

### 6. Enumerations
- `enum`: A set of named constants (e.g., `enum Day { Monday, Tuesday, Wednesday }`)

### 7. Nullable Value Types
- Any value type can be made nullable using `?` (e.g., `int?` can be an integer or `null`)

## Reference Types
Reference types store a reference to the data (allocated on the heap) rather than the data itself. They include:

### 1. String
- `string`: A sequence of Unicode characters (e.g., `"Hello, World!"`)

### 2. Object
- `object`: The base type for all types in C# (can hold any value or reference)

### 3. Class
- Custom reference types defined using the `class` keyword (e.g., `class Person { string Name; int Age; }`)

### 4. Arrays
- Collections of items of the same type (e.g., `int[] numbers = new int[5];`)

### 5. Interfaces
- Define a contract that classes or structs can implement (e.g., `interface IExample { void Method(); }`)

### 6. Delegates
- Type-safe function pointers (e.g., `delegate void MyDelegate(string message);`)

### 7. Dynamic
- `dynamic`: Allows runtime type resolution, bypassing compile-time type checking

## Special Types
- **`var`**: Implicitly typed variable; the compiler infers the type (e.g., `var x = 10;` makes `x` an `int`).
- **`nint` and `nuint`**: Native-sized integers (size depends on the platform, 32-bit or 64-bit).

## Key Differences
- **Value Types**: Copied by value, default to `0`, `false`, etc., if uninitialized in a struct.
- **Reference Types**: Copied by reference, default to `null` if uninitialized.

## Examples:
```cs
using System;

namespace DataTypesDemo
{
    class Program
    {
        // Define an enum
        enum Day { Monday, Tuesday, Wednesday }

        // Define a struct
        struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y) { X = x; Y = y; }
        }

        // Define a class
        class Person
        {
            public string Name;
            public int Age;
            public Person(string name, int age) { Name = name; Age = age; }
        }

        // Define an interface
        interface IExample
        {
            void Display();
        }

        // Define a class implementing the interface
        class ExampleClass : IExample
        {
            public void Display() => Console.WriteLine("Interface method called.");
        }

        // Define a delegate
        delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            // Value Types: Integers
            sbyte sb = -100;
            byte b = 200;
            short s = -30000;
            ushort us = 60000;
            int i = -2000000000;
            uint ui = 4000000000;
            long l = -9000000000000000000;
            ulong ul = 18000000000000000000;

            // Value Types: Floating-Point
            float f = 3.14f;
            double d = 2.71828;
            decimal dec = 123.456789m;

            // Value Types: Boolean and Character
            bool isTrue = true;
            char c = 'A';

            // Value Types: Struct
            Point point = new Point(10, 20);

            // Value Types: Enum
            Day today = Day.Monday;

            // Value Types: Nullable
            int? nullableInt = null;

            // Reference Types: String
            string str = "Hello, C#!";

            // Reference Types: Object
            object obj = 42;

            // Reference Types: Class
            Person person = new Person("Alice", 30);

            // Reference Types: Array
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Reference Types: Interface
            IExample example = new ExampleClass();

            // Reference Types: Delegate
            MyDelegate del = (msg) => Console.WriteLine(msg);
            
            // Reference Types: Dynamic
            dynamic dyn = 100;
            dyn = "Now I'm a string!";

            // Special Types: var
            var inferred = 10; // Compiler infers int

            // Special Types: nint and nuint (platform-dependent size)
            nint nativeInt = 500;
            nuint nativeUInt = 1000;

            // Output all values to demonstrate usage
            Console.WriteLine("--- Value Types ---");
            Console.WriteLine($"sbyte: {sb}");
            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"ushort: {us}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"uint: {ui}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"ulong: {ul}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"bool: {isTrue}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"struct Point: ({point.X}, {point.Y})");
            Console.WriteLine($"enum Day: {today}");
            Console.WriteLine($"nullable int: {nullableInt ?? -1} (null displayed as -1)");

            Console.WriteLine("\n--- Reference Types ---");
            Console.WriteLine($"string: {str}");
            Console.WriteLine($"object: {obj}");
            Console.WriteLine($"class Person: {person.Name}, Age {person.Age}");
            Console.WriteLine($"array: [{string.Join(", ", numbers)}]");
            Console.Write("interface: ");
            example.Display();
            Console.Write("delegate: ");
            del("Delegate executed!");
            Console.WriteLine($"dynamic: {dyn}");

            Console.WriteLine("\n--- Special Types ---");
            Console.WriteLine($"var (inferred as int): {inferred}");
            Console.WriteLine($"nint: {nativeInt}");
            Console.WriteLine($"nuint: {nativeUInt}");
        }
    }
}
```
