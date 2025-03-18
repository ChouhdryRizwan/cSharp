using System;

// Delegate define kiya jo 2 integers accept karega aur return kuch nahi karega (void)
public delegate void CalculationDelegate(int a, int b);

class Program
{
    // Different Calculation Methods
    static void Add(int x, int y) => Console.WriteLine($"Addition: {x + y}");
    static void Subtract(int x, int y) => Console.WriteLine($"Subtraction: {x - y}");
    static void Multiply(int x, int y) => Console.WriteLine($"Multiplication: {x * y}");
    static void Divide(int x, int y) =>
        Console.WriteLine(y != 0 ? $"Division: {x / y}" : "Cannot divide by zero!");

    static void Main()
    {
        CalculationDelegate calc = Add;  // Pehla method assign kiya
        calc += Subtract;  // Dusra method add kiya
        calc += Multiply;  // Teesra method add kiya
        calc += Divide;    // Chautha method add kiya

        Console.WriteLine("Performing all calculations:");
        calc(10, 5); // Jab delegate call hoga, ye sare methods execute karega

        Console.WriteLine("\nRemoving Subtraction:");
        calc -= Subtract;  // Subtract method remove kar diya
        calc(10, 5);
    }
}
