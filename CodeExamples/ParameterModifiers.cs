using System;

// ref modifier
void ModifyValue(ref int number)
{
    number += 10; // Modify the original value
}

int myNumber = 5;
ModifyValue(ref myNumber);
Console.WriteLine(myNumber); // Output: 15


// out modifier
void GetValues(out int result)
{
    result = 42; // Must be assigned before the method exits
}

int myValue;
GetValues(out myValue);
Console.WriteLine(myValue); // Output: 42

// in modifier
void PrintValue(in int number)
{
    Console.WriteLine(number); // Allowed
    // number += 10; // Not allowed (will cause a compile error)
}

int myNumber = 100;
PrintValue(in myNumber);