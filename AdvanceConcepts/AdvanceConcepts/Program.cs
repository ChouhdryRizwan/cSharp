using System;

public class Program
{
    // No parameter
    Action show = () => Console.WriteLine("Hello, World!");

    // With parameter
    Action<string> welcome = name => Console.WriteLine("Welcome " + name);

    //calculation
    static Func<int, int, int> add = (a, b) => a + b;


    public static void Main()
    {
        Program p = new Program();
        //p.show();
        //p.welcome("Ali");

        int result = add(10, 20);
        Console.WriteLine("Addition: " + result); 

    }
}



