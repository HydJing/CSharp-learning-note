# Abstract Class

## What is it?

An **abstract class** is a class that **cannot be instantiated directly**. Instead, it serves as a **blueprint** for other classes. It is meant to be inherited by other classes that provide specific implementations for its abstract methods.

An **abstract method** is a method that is **declared but not defined** in the abstract class. **It must be overridden** in a derived class.

[Click to see code example](../../CodeExamples/AbstractClass.cs)

## When to Use Which?
 - Abstract Class:
 	- You need to provide **default behavior** for some methods but require specific implementation for others.
    - You want to share **common fields and methods** among all subclasses.
    - You need to enforce a **structure** in a set of related classes.
 - Interface:
    - You need to define **only method signatures** without any implementation.
    - You need **multiple inheritance** (since a class can inherit multiple interfaces).
    - You want to enforce a contract across **completely unrelated classes**.

## Best Practices
 - **Use abstract classes for closely related objects** (e.g., `Animal`, `Vehicle`).
 - **Provide common functionality in the abstract class** to avoid code duplication.
 - **Use abstract methods only when absolutely necessary**, as they require subclasses to implement them.

## Common Mistakes
 - **Trying to instantiate an abstract class** ¡ú `new AbstractClass()` will result in an error.
 - **Forgetting to override an abstract method** ¡ú A subclass **must** implement all abstract methods.
 - **Using an abstract class when an interface is more appropriate** ¡ú If no method implementations are needed, an interface is a better choice.

## Conclusion
Abstract classes and methods are essential tools in object-oriented programming. They allow developers to create a **blueprint** for related classes, enforcing a structure while still allowing flexibility in implementation.