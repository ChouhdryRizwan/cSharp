using myNamespace;
using NRecordTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student()
        {
            Name = "Rizwan",
            Id = 44203
        };

        Student student2 = new Student()
        {
            Name = "Rizwan",
            Id = 44203
        };

        //Console.WriteLine(student1);
        //Console.WriteLine(student1 == student2);

        Rizwan rizwan = new Rizwan("Rizwan Tahir", 19);
        Rizwan rizwan2 = rizwan with { name = "Muhammad Rizwan Tahir" };

        //Console.WriteLine(rizwan);
        //Console.WriteLine(rizwan2);

        Person p1 = new Person();
        p1.Name = "Ali";

        Person p2 = p1;  // Reference assign ho gaya

        p2.Name = "Ahmed";  // p2 change karega to p1 bhi change ho jayega

        //Console.WriteLine(p1.Name);  // Output: Ahmed
        //Console.WriteLine(p2.Name);  // Output: Ahmed

        //myStack stack1 = new myStack();

        //MyClass myClass = new MyClass();

        //FirstNamespace.MyClass obj1 = new FirstNamespace.MyClass();
        //obj1.Show();  // Output: Hello from FirstNamespace!

        //SecondNamespace.MyClass obj2 = new SecondNamespace.MyClass();
        //obj2.Show();  // Output: Hello from SecondNamespace!

    }
        
    public record Student {
        public string Name { get; set; }
        public int Id { get; set; }
    
    }

    public record Rizwan(string name, int age);
        
}

namespace FirstNamespace
{
    class MyClass
    {
        public void Show()
        {
            Console.WriteLine("Hello from FirstNamespace!");
        }
    }
}

namespace SecondNamespace
{
    class MyClass
    {
        public void Show()
        {
            Console.WriteLine("Hello from SecondNamespace!");
        }
    }
}