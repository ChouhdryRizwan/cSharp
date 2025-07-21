internal class Program
{
    private static void Main(string[] args)
    {
        A newA = new A();
        //newA.age = -10;
        //Console.WriteLine(newA.age);

        //newA.AgeDetail(-20);
    }

}

class A {
    //private int _age; //field
    public int age { get; set; } //property

    //public int age
    //{
    //    get { return this._age; }
    //    set { this._age = value; }
    //}

    //public void AgeDetail(int newage) {
    //    if (newage < 0)
    //    {
    //        Console.WriteLine("Age must be greater than 0");
    //    }
    //    else {
    //        this.age = newage;
    //    }
    //    Console.WriteLine("Age is set to: " + this.age);
    //}
}