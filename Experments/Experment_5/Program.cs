using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Async and Await Example");
        Console.WriteLine("Program started.");

        Task reportTask = PrepareReportAsync();

        Console.WriteLine("Main method is free while the report is being prepared.");

        await reportTask;

        Console.WriteLine("Program finished.");
    }

    static async Task PrepareReportAsync()
    {
        Console.WriteLine("Preparing report...");
        await Task.Delay(3000);
        Console.WriteLine("Report prepared successfully.");
    }
}
