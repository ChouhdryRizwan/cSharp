internal class Program
{
    private static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>();  // Works with int
        intBox.Set(5);
        Console.WriteLine(intBox.Get());   // Output: 5

        Box<double> stringBox = new Box<double>();  // Works with string
        stringBox.Set(5.5);
        Console.WriteLine(stringBox.Get());  // Output: Hello


        // Generic Mehtods

        static void Print<T>(T value)  // Generic method
        {
            Console.WriteLine(value);
        }

        static void Main()
        {
            Print(10);       // int
            Print("Hello");  // string
            Print(3.14);     // double
        }
    }
}

class Box<T> // <T> means generic type
{
    private T size;

    public void Set(T newItem)
    {
        size = newItem;
    }

    public T Get()
    {
        return size;
    }
}

