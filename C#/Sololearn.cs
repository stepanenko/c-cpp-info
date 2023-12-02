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
