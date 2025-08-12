// basic
using System;

void RecursiveFunction()
{
    // Base Case: Stop when a certain condition is met
    if (someCondition)
    {
        return;
    }

    // Recursive Case: Call itself with modified parameters
    RecursiveFunction();
}

// counting down example

using System;
 
class Program
{
    static void CountDown(int number)
    {
        // Base case: Stop when we reach 0
        if (number == 0)
        {
            Console.WriteLine("Blast off!");
            return;
        }

        Console.WriteLine(number);

        // Recursive call: Reduce the number and call the function again
        CountDown(number - 1);
    }

    static void Main()
    {
        CountDown(5);
    }
}

// 5
// 4
// 3
// 2
// 1
// Blast off!


// Factorial Calculation
// 5! = 5 ¡Á 4 ¡Á 3 ¡Á 2 ¡Á 1 = 120
class Program
{
    static int Factorial(int n)
    {
        // Base Case: Factorial of 0 or 1 is 1
        if (n == 0 || n == 1)
        {
            return 1;
        }

        // Recursive Case: Multiply n by the factorial of (n-1)
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Factorial of 5: " + Factorial(5)); // Factorial of 5: 120
    }
}

