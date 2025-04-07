//using System;
//using System.Threading.Tasks;

//public class Program
//{
//    // Method to be executed in a separate thread
//    public static void PrintNumbers()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine(i);
//            Thread.Sleep(1000);  // Sleep for 1 second
//        }
//    }

//    public static void Main()
//    {
//        Thread thread = new Thread(PrintNumbers); // Creating a thread
//        thread.Start(); // Starting the thread

//        Console.WriteLine("Main thread is running...");
//        thread.Join();  // Waiting for the thread to finish

//        Console.WriteLine("Main thread has finished.");
//    }
//}
