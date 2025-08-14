// basic syntax
using System;

class BaseClass
{
    public void ShowMessage()
    {
        Console.WriteLine("Message from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public new void ShowMessage()
    {
        Console.WriteLine("Message from DerivedClass");
    }
}

// another example
class Animal
{
    public void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public new void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

Animal myAnimal = new Animal();
myAnimal.Speak();  // Output: The animal makes a sound.

Dog myDog = new Dog();
myDog.Speak();  // Output: The dog barks.

Animal myPet = new Dog();
myPet.Speak();  // Output: The animal makes a sound.


// Overriding
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}