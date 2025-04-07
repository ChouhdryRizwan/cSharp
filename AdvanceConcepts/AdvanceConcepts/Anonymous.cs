//using System;

//public class Program
//{
//    public delegate void ShowMessage();
//    public delegate int Operation(int a, int b);

//    public static void Main()
//    {
//        // Anonymous method assigned to delegate
//        ShowMessage show = delegate ()
//        {
//            Console.WriteLine("Hello, this is an anonymous method!");
//        };

//        // Calling the delegate
//        show();

//        Operation add = delegate (int x, int y)
//        {
//            return x + y;
//        };

//        int result = add(10, 20);
//        Console.WriteLine("Addition Result: " + result);
//    }
//}


//Annonymous Type

//    var student = new
//                  {
//                      Name = "Ali",
//                      Age = 22,
//                      Course = "Computer Science"
//                  };

//Console.WriteLine(student.Name); // Output: Ali