## Singleton Design Pattern

#### What is the Singleton Design Pattern?
It's a creational design pattern that ensures:
- Only one instance of a class is created.
- That instance is globally accessible throughout the application.

## Structure of Singleton Pattern
- A private constructor to prevent external instantiation.
- A private static field to hold the instance.
- A public static property to provide access.

Example:
```csharp
public class Singleton
{
    private static Singleton _instance;
    private Singleton() { }
    public static Singleton Instance => _instance ??= new Singleton();
}
```

## Real-World Usage Examples
- Logger services

- Configuration managers

- Caching systems

- Database connection pools

- File or resource managers

### What are the main drawbacks of Singleton?
- Global state → leads to tight coupling
- Harder to unit test (must use mocking frameworks or refactor)
- May hide dependencies → reduces code clarity
- Can hurt scalability if overused

## Mock Interview Questions
1. How does Singleton affect unit testing?
    - Singleton introduces global state, which can make tests dependent on shared state.
    - To make it testable, we should inject it through DI and mock its interface in tests.

2. What is the difference between Singleton and Static classes?
    | Singleton | Static|
    |-----------|--------|
    | Can implement inetrfaces| Cannot implement inetrfaces|
    | Supports lazy initialization | Intialized when first accessed|
    | Can have instance state | Only static members, no instance state|
    | Useful with DI | Cannot be injected into DI |

3. How can you use Singleton in ASP.NET Core with Dependency Injection?
    
    Register it in the DI container:
    ```csharp
    services.AddSingleton<IMyService, MyService>();
    ```
4. What is Lazy<T> and how does it help with Singleton?
    
    Lazy<T> defers object creation until the first access and provides built-in thread safety, simplifying Singleton implementation.