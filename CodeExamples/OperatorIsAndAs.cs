// is basic syntax
using System;

class Animal { }
class Dog : Animal { }

Animal myPet = new Dog();

if (myPet is Dog)
{
    Console.WriteLine("myPet is a Dog");
}
else
{
    Console.WriteLine("myPet is NOT a Dog");
}

// after C# 7.0, is also used pattern matching
object obj = "Hello World";
if (obj is string message)
{
    Console.WriteLine($"The message is: {message}"); // "Hello World", scope var
}

// as basic syntax
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal myPet = new Dog();

Dog myDog = myPet as Dog;
if (myDog != null)
{
    Console.WriteLine("Successfully cast to Dog.");
}
else
{
    Console.WriteLine("Conversion failed.");
}

// but 
Animal myPet = new Cat();
Dog myDog = myPet as Dog; // myDog is null since failed to convertion