internal class Program
{
    private static void Main(string[] args)
    {
        Vehcile myvehicle = new Vehcile();
        myvehicle.company = "Toyota";
        Console.WriteLine(myvehicle.company);

        Console.WriteLine("------------------------");

        Vehcile myvehcile2 = new Vehcile();
        myvehcile2.company = "Honda";
        Console.WriteLine(myvehcile2.company);
    }
}

class Vehcile {

    public string company;

}