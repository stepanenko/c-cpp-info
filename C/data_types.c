#include <stdio.h>
#include <stdint.h> // For fixed-width integer types

// Define an enum
enum Color { Red, Green, Blue };

// Define a struct
struct Point {
    int x;
    int y;
};

// Define a union
union Data {
    int i;
    float f;
};

// Define a typedef
typedef unsigned long ulong;

// Function declaration (demonstrates function type)
int add(int a, int b) {
    return a + b;
}

int main() {
    // Basic Types: Integers
    char c = 'A';               // Often used for characters
    signed char sc = -100;      // Explicitly signed
    unsigned char uc = 200;     // Unsigned
    short s = -30000;
    unsigned short us = 60000;
    int i = -2000000;
    unsigned int ui = 4000000;
    long l = -9000000000L;      // 'L' suffix for long
    unsigned long ul = 18000000000UL; // 'UL' for unsigned long
    long long ll = -900000000000000LL;
    unsigned long long ull = 1800000000000000ULL;

    // Basic Types: Floating-Point
    float f = 3.14f;            // 'f' suffix for float
    double d = 2.71828;
    long double ld = 1.41421356237L; // 'L' suffix for long double

    // Derived Types: Pointer
    int value = 42;
    int* ptr = &value;

    // Derived Types: Array
    int arr[5] = {1, 2, 3, 4, 5};

    // User-Defined Types: Enum
    enum Color color = Green;

    // User-Defined Types: Struct
    struct Point point = {10, 20};

    // User-Defined Types: Union
    union Data data;
    data.i = 100; // Only one member is active at a time

    // User-Defined Types: Typedef
    ulong bigNum = 1234567890UL;

    // Output all values
    printf("--- Basic Types: Integers ---\n");
    printf("char: %c (ASCII %d)\n", c, c);
    printf("signed char: %d\n", sc);
    printf("unsigned char: %u\n", uc);
    printf("short: %d\n", s);
    printf("unsigned short: %u\n", us);
    printf("int: %d\n", i);
    printf("unsigned int: %u\n", ui);
    printf("long: %ld\n", l);
    printf("unsigned long: %lu\n", ul);
    printf("long long: %lld\n", ll);
    printf("unsigned long long: %llu\n", ull);

    printf("\n--- Basic Types: Floating-Point ---\n");
    printf("float: %.2f\n", f);
    printf("double: %.5f\n", d);
    printf("long double: %.10Lf\n", ld); // %Lf for long double

    printf("\n--- Derived Types ---\n");
    printf("pointer: %p (points to %d)\n", (void*)ptr, *ptr);
    printf("array: [%d, %d, %d, %d, %d]\n", arr[0], arr[1], arr[2], arr[3], arr[4]);
    printf("function call (add): %d\n", add(5, 3));

    printf("\n--- User-Defined Types ---\n");
    printf("enum Color: %d (Green)\n", color);
    printf("struct Point: (%d, %d)\n", point.x, point.y);
    printf("union Data (int): %d\n", data.i);
    data.f = 3.14f; // Switch to float
    printf("union Data (float): %.2f\n", data.f);
    printf("typedef ulong: %lu\n", bigNum);

    return 0;
}
