# Abstract Class VS Interface

## What is it?

### Abstract Class
An **abstract class** is a class that **cannot be instantiated directly**. Instead, it serves as a **blueprint** for other classes. It is meant to be inherited by other classes that provide specific implementations for its abstract methods.

 - **Abstract members** (methods or properties without implementation) ¡ª these must be implemented by derived classes.
 - **Concrete members** (fully implemented methods or properties) ¡ª these can be inherited and reused by derived classes.
 - **Fields and constructors** ¡ª like any normal class.

Think of an abstract class as a **partially built template**: some functionality is ready to use, and some is left for subclasses to define.

```
public abstract class PrinterBase
{
    public abstract void Print(string document); // must be implemented
 
    public virtual void PowerOn()
    {
        Console.WriteLine("Powering on...");
    }
}
```
### Interface
An interface is a pure contract ¡ª it defines what a class must do, but not how it does it.
It can contain:

 - Method signatures
 - Property signatures
 - Event declarations
 - Indexers

It **cannot** contain:

 - Fields
 - Constructors
 - Implementations (before C# 8 ¡ª with C# 8+, default interface methods exist, but this is generally avoided in basic design for clarity)

A class or struct that implements an interface **must** provide an implementation for all of its members.

```
public interface IPrintable
{
    void Print(string document);
}
 
public interface IScannable
{
    void Scan();
}
```

[Click to see code example](../../CodeExamples/AbstractClassVSInterface.cs)

## When to Use Which?
 - Abstract Class:
 	- You have common functionality that multiple derived classes should share.
    - You want to provide default behavior for some members but require others to be overridden.
    - You expect the base type to evolve over time without breaking many implementations.
    - You want to maintain shared state across derived classes.
 - Interface:
    - You only care about the capabilities of a class, not its inheritance hierarchy.
    - You need multiple inheritance of behavior contracts (since C# classes can¡¯t inherit from more than one base class).
    - You want maximum flexibility and decoupling between components.
    - You¡¯re defining a plugin or service API where the actual implementation may vary widely.

## Best Practices
 - Abstract Class:
    - **Use abstract classes for closely related objects** (e.g., `Animal`, `Vehicle`).
    - **Provide common functionality in the abstract class** to avoid code duplication.
    - **Use abstract methods only when absolutely necessary**, as they require subclasses to implement them.
 - Interface:
    - Use interfaces (e.g., `IPaymentService`) instead of concrete classes to enable flexibility and testing.
    - Small, specific contracts following the Interface Segregation Principle.
    - Use descriptive `I`-prefixed names and XML comments to define behavior clearly.

## Common Mistakes
 - Abstract Class:
    - **Trying to instantiate an abstract class** ¡ú `new AbstractClass()` will result in an error.
    - **Forgetting to override an abstract method** ¡ú A subclass **must** implement all abstract methods.
    - **Using an abstract class when an interface is more appropriate** ¡ú If no method implementations are needed, an interface is a better choice.
 - Interface:
    - Creating unnecessary interfaces for single-use classes.
    - Combining unrelated responsibilities makes implementations cumbersome.
    - Avoid putting persistence or UI logic into generic service contracts.

## Conclusion
 - **Abstract classes** are for ¡°is-a¡± relationships with shared implementation. They let you define a **template with reusable code**.

 - **Interfaces** are for defining **contracts** without enforcing how they are implemented, allowing classes to commit to multiple capabilities without being locked into a single hierarchy.

```
public abstract class PrinterBase : IPrintable
{
    public abstract void Print(string document);
 
    public virtual void PowerOn()
    {
        Console.WriteLine("Powering on...");
    }
}
 
public interface IScannable
{
    void Scan();
}
```