using System;
using System.Threading.Tasks;

public class Program
{
    // Asynchronous method to simulate number printing with delay
    public static async Task PrintNumbersAsync()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            await Task.Delay(1000);  // Asynchronous delay for 1 second
        }
    }

    public static async Task Main()
    {
        Console.WriteLine("Main thread is running...");

        // Calling the asynchronous method
        await PrintNumbersAsync();  // Wait for PrintNumbersAsync to complete

        Console.WriteLine("Main thread has finished.");
    }
}
