# Constructs

## What is it?

A struct is a **lightweight value type** that can contain fields, properties, methods, and constructors, but it cannot inherit from another struct or class (only implement interfaces). Structs are copied by value, meaning that **assigning one struct to another creates a full copy**, not a reference. They are ideal for **small, immutable, or frequently created objects**, such as points, rectangles, or complex numbers.

[Click to see code example](../../CodeExamples/Constructs.cs)

## When to use
Use a struct when the type is small (typically under 16 bytes), represents a single value or lightweight object, is immutable, and will not be boxed frequently. For example, Point, DateTime, and Guid are implemented as structs.

Use a class when the object is large, mutable, or requires inheritance, polymorphism, or reference semantics. Classes are preferred when managing shared data or complex objects with long lifetimes.

## Best Practices
 - Keep small and immutable.
 - Avoid defining structs with many fields or large memory footprint.
 - Implement interfaces carefully; boxing can occur if passed as object.
 - Favor readonly fields and properties to prevent accidental mutation.

## Common Mistakes
 - Using struct for large data, causing expensive copies.
 - Defining mutable structs, leading to unexpected behavior in collections or methods.
 - Relying on inheritance, which structs don¡¯t support.
 - Ignoring boxing/unboxing performance penalties when using interfaces or object references.

## Conclusion
Structs are lightweight, value types suitable for small, immutable data with performance benefits. Classes are reference types designed for complex, mutable objects with support for inheritance and polymorphism. Choosing the right type depends on size, mutability, and behavior; using structs improperly can lead to subtle bugs and performance issues, while classes provide flexibility but may incur more heap allocations and garbage collection.