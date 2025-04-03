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
