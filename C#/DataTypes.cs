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
