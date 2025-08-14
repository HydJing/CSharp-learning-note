# Operator has and is

## What is it?

In C#, objects interact with each other in two fundamental ways: through **composition (HAS-A relationship)** and **inheritance (IS-A relationship)**. These relationships help define how different classes are connected and how they share data and functionality.

[Click to see code example](../../CodeExamples/RelationshipHasAndIs.cs)

## When to Use Which?
Relationship Use Case **IS-A (Inheritance)** When you need to create a hierarchical relationship where the derived class is a specialized version of the base class. **HAS-A (Composition)** When a class should contain another class as a component rather than being a subclass. 

## Best Practices
 - Use **inheritance (IS-A)** when there is a clear hierarchical relationship.
 - Use **composition (HAS-A)** when objects need to interact but don¡¯t share a common base type.
 - Favor **composition over inheritance** when possible to reduce tight coupling.
 - Follow **Single Responsibility Principle (SRP)**¡ªeach class should have one responsibility.

## Common Mistakes
 - Using inheritance when composition would be better (e.g., making **Car inherit from Engine** instead of having an Engine object inside Car).
 - Overusing inheritance, leading to deep class hierarchies that are hard to manage.
 - Ignoring encapsulation by exposing internal class members unnecessarily.
 - Not considering polymorphism when inheritance is used.

## Conclusion
Understanding the **(HAS-A) and (IS-A)** relationship in C# is critical for writing well-structured and maintainable object-oriented code.

 - The `IS-A` relationship (inheritance) helps create a structured hierarchy where one class extends another.

 - The `HAS-A` relationship (composition) allows for flexible and reusable code by including other objects instead of extending them.

 - Choosing between inheritance and composition depends on the nature of the relationship between objects and the level of flexibility needed.