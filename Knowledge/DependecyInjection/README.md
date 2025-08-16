# Dependecy Injection

## What is it?

In modern software development, writing clean, maintainable, and scalable code is the main focus every developer should have. One of the fundamental principles that help achieve this is **Dependency Injection (DI)**. It is a powerful technique that improves the flexibility, testability, and overall design of applications.

[Click to see code example](../../CodeExamples/DependecyInjection.cs)

## Different types
 - Constructor Injection (Most common & preferred): Injects dependencies via the constructor.

 - Property Injection: Dependencies are set through public properties.
    ```
    public class UserService
    {
        public IEmailService EmailService { get; set; }
    }
   ```
 - Method Injection: Dependencies are passed as method parameters.
   ```
    public void RegisterUser(string name, IEmailService emailService) { }
   ```

## Best Practices
 - Depend on abstractions �� Use interfaces for easy testing and swapping implementations.
 - Correct lifetimes �� Transient (new each time), Scoped (per request), Singleton (app-wide).
 - Minimal constructor parameters �� More than 3�C5 indicates too much responsibility.
 - Central registration �� Configure services in one place (Startup/Program.cs).
 - Configuration binding �� Use `IOptions<T>` instead of injecting raw config values.

## Common Mistakes
 - Over-injecting �� Too many dependencies in one class.
 - Lifetime mismatch �� Injecting Scoped into Singleton causes runtime issues.
 - Service locator pattern �� Calling GetService() inside code bypasses DI benefits.
 - Not disposing services �� Manually created disposables won��t be cleaned up.
 - Tight coupling to container �� Keep business logic free of DI container calls.

## Conclusion
Dependency Injection is essential in modern C# for building clean, maintainable, and testable applications. By injecting interfaces instead of concrete types and managing service lifetimes properly, you reduce coupling and improve flexibility