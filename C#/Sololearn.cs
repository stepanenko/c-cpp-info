// 1
// redesign the given method so that it will take the given input
// as the name of the user and output the welcome message with it

using System;

public class Program {
    static void Main(string[] args) {
        Welcome();   
    }

    static void Welcome() {
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome, {name}!");
    }
}


// 2
// Fix and complete the Area method, which takes the length and width as arguments,
// to calculate and return the area. Then call the method for the given inputs.

using System;

public class Program {
    static void Main(string[] args) {
        int width = Convert.ToInt32(Console.ReadLine());
        int length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Area(width, length));
    }

    static int Area(int w, int l) {
        return w * l;
    }
}

// 3
// Example of a class

class Person {
    int age;
    public string name;
    public void SayHi() {
        Console.WriteLine("Hi");
    }
}

// A member that has been defined public can be accessed from outside the class,
// as long as it's anywhere within the scope of the class object.
// You can also designate class members as private or protected.
// If no access modifier is defined, the member is private by default.

// instantiate an object of type Person in Main:
static void Main(string[] args) {
    Person p1 = new Person();
    // the new operator instantiates an object and returns a reference to its location
    p1.name = "John";
    p1.SayHi();
}
