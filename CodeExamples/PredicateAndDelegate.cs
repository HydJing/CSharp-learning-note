using System;
using System.Collections.Generic;

public delegate void Logger(string message);

class Program
{
    static void Main()
    {
        // Delegate instance for logging
        Logger log = Console.WriteLine;

        // Sample data
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6 };

        // Predicate to filter even numbers
        Predicate<int> isEven = n => n % 2 == 0;

        // Use Predicate<T> with List<T>.FindAll to get even numbers
        List<int> evenNumbers = numbers.FindAll(isEven);

        // Use delegate to log results
        foreach (int num in evenNumbers)
        {
            log($"Even number found: {num}");
        }
    }
}
