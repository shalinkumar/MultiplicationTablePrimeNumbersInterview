// See https://aka.ms/new-console-template for more information
using MultiplicationTablePrimeNumbersInterview;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number = ");
        var number = 0;
        bool success = int.TryParse(Console.ReadLine(), out number);
        if (success)
            Solution.PrintGrid(number);
        else
            Console.WriteLine("Invalid number");
    }
}