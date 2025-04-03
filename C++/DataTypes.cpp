#include <iostream>
#include <cstdint> // For fixed-width integer types

// Define an enum
enum Color { Red, Green, Blue };

// Define a struct
struct Point {
    int x;
    int y;
    Point(int x_, int y_) : x(x_), y(y_) {} // Constructor
};

// Define a class (C++ enhancement over C struct)
class Person {
public:
    std::string name;
    int age;
    Person(std::string n, int a) : name(n), age(a) {} // Constructor
    void display() const { std::cout << name << ", Age " << age << "\n"; }
};

// Define a union
union Data {
    int i;
    float f;
    Data(int val) : i(val) {} // Constructor (C++ allows this)
};

// Define a typedef (C-style)
typedef unsigned long ulong;

// Define a using alias (modern C++ alternative to typedef)
using u64 = uint64_t;

int main() {
    // Basic Types: Integers
    char c = 'A';
    signed char sc = -100;
    unsigned char uc = 200;
    short s = -30000;
    unsigned short us = 60000;
    int i = -2000000;
    unsigned int ui = 4000000;
    long l = -9000000000L;
    unsigned long ul = 18000000000UL;
    long long ll = -900000000000000LL;
    unsigned long long ull = 1800000000000000ULL;

    // Basic Types: Floating-Point
    float f = 3.14f;
    double d = 2.71828;
    long double ld = 1.41421356237L;

    // Basic Types: C++ Specific
    bool b = true;
    wchar_t wc = L'Z'; // Wide character

    // Derived Types: Pointer
    int value = 42;
    int* ptr = &value;

    // Derived Types: Array (C-style)
    int arr[5] = {1, 2, 3, 4, 5};

    // Derived Types: Function (C-style)
    auto add = [](int a, int b) { return a + b; }; // Lambda as a function

    // User-Defined Types: Enum
    Color color = Green;

    // User-Defined Types: Struct
    Point point(10, 20);

    // User-Defined Types: Class
    Person person("Alice", 30);

    // User-Defined Types: Union
    Data data(100);

    // User-Defined Types: Typedef and Alias
    ulong bigNum = 1234567890UL;
    u64 veryBigNum = 9876543210ULL;

    // Output all values
    std::cout << "--- Basic Types: Integers ---\n";
    std::cout << "char: " << c << " (ASCII " << static_cast<int>(c) << ")\n";
    std::cout << "signed char: " << static_cast<int>(sc) << "\n";
    std::cout << "unsigned char: " << static_cast<unsigned>(uc) << "\n";
    std::cout << "short: " << s << "\n";
    std::cout << "unsigned short: " << us << "\n";
    std::cout << "int: " << i << "\n";
    std::cout << "unsigned int: " << ui << "\n";
    std::cout << "long: " << l << "\n";
    std::cout << "unsigned long: " << ul << "\n";
    std::cout << "long long: " << ll << "\n";
    std::cout << "unsigned long long: " << ull << "\n";

    std::cout << "\n--- Basic Types: Floating-Point ---\n";
    std::cout << "float: " << f << "\n";
    std::cout << "double: " << d << "\n";
    std::cout << "long double: " << ld << "\n";

    std::cout << "\n--- Basic Types: C++ Specific ---\n";
    std::cout << "bool: " << std::boolalpha << b << "\n"; // std::boolalpha for true/false output
    std::cout << "wchar_t: " << static_cast<char>(wc) << " (value " << wc << ")\n";

    std::cout << "\n--- Derived Types ---\n";
    std::cout << "pointer: " << ptr << " (points to " << *ptr << ")\n";
    std::cout << "array: [" << arr[0] << ", " << arr[1] << ", " << arr[2] << ", " << arr[3] << ", " << arr[4] << "]\n";
    std::cout << "function call (add): " << add(5, 3) << "\n";

    std::cout << "\n--- User-Defined Types ---\n";
    std::cout << "enum Color: " << color << " (Green)\n";
    std::cout << "struct Point: (" << point.x << ", " << point.y << ")\n";
    std::cout << "class Person: ";
    person.display();
    std::cout << "union Data (int): " << data.i << "\n";
    data.f = 3.14f; // Switch to float
    std::cout << "union Data (float): " << data.f << "\n";
    std::cout << "typedef ulong: " << bigNum << "\n";
    std::cout << "using u64: " << veryBigNum << "\n";

    return 0;
}
