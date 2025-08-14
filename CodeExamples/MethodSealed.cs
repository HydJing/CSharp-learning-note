// basic syntax
class BaseClass
{
    public virtual void ShowMessage()
    {
        Console.WriteLine("Message from BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public sealed override void ShowMessage()
    {
        Console.WriteLine("Message from DerivedClass (Sealed)");
    }
}

// This will cause an error because ShowMessage() is sealed in DerivedClass
class SubDerivedClass : DerivedClass
{
    // public override void ShowMessage() {} // ERROR: Cannot override because it's sealed
}

// another example
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Dog : Animal
{
    public sealed override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Bulldog : Dog
{
    // public override void MakeSound() {} // ERROR: Cannot override because it's sealed
}