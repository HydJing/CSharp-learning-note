// Abstract class - cannot be instantiated
using System;

abstract class Animal
{
    // Abstract method - must be implemented in derived classes
    public abstract void MakeSound();

    // Non-abstract method - can have a default implementation
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

// Concrete class that inherits from Animal
class Dog : Animal
{
    // Providing implementation for abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

class Program
{
    static void Main()
    {
        // Animal animal = new Animal(); // ERROR: Cannot instantiate abstract class
        Dog myDog = new Dog();
        myDog.MakeSound(); // Output: Woof! Woof!
        myDog.Sleep(); // Output: Sleeping...
    }
}

// Another example
abstract class Vehicle
{
    public int Speed { get; set; }
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("The car is driving.");
    }
}