# Expression Bodied Members

## What is it?
An **Expression Bodied Member** is a shorthand syntax in C# that allows defining simple methods, properties, or even constructors using the **lambda arrow** (`=>`) instead of curly braces `{ }`.

This feature is useful when a method or property contains only a **single expression**, making the code cleaner and reducing unnecessary syntax.

[Click to see code example](../../CodeExamples/ExpressionBodiedMembers.cs)

## When to Use Expression Bodied Members?
 - Use them when **methods or properties contain only a single expression**.
 - They are best for **readability and conciseness**.
 - They are great for **simple get-only properties, lightweight methods, constructors, finalizers, and indexers**.

## Best Practices
 - Use Expression Bodied syntax for simple operations.
 - Keep code concise but still readable.
 - Use it in conjunction with standard methods when necessary.

## Common Mistakes
 - **Using it for complex logic** ¨C If a method has multiple lines of code, **stick to regular methods** instead of Expression Bodied syntax.

## Conclusion
Expression Bodied Members allow you to write **concise, readable, and efficient** code by reducing unnecessary syntax. While they aren¡¯t required for all methods or properties, they are an excellent tool for **simplifying short, single-expression logic**.