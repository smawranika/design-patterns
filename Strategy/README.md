## Strategy Design Pattern

#### What is the Strategy Design Pattern?
- It is a behavioral design pattern.
- It defines a family of algorithms, encapsulates each one, and makes them interchangeable at runtime.
- It allows the algorithm to vary independently from the clients that use it.

## Structure of Strategy Pattern
- Strategy (Interface): Common interface for all supported algorithms.
- Concrete Strategies (Classes): Implement different algorithms following the Strategy interface.
- Context (Class): Maintains a reference to a Strategy object and uses it.
 
## Real-World Example (Simple Analogy)

Example: Payment System

Imagine you are building a shopping cart.
The customer can pay via Credit Card, PayPal, or UPI.

Each payment method has a different processing logic.
Instead of hardcoding all payment logics into the ShoppingCart, you use the Strategy Pattern!

## Key Points to Remember

| Aspect | Details|  
| -------- | -------- |  
| Problem   | Class behavior needs to change dynamically. |  
| Solution   | Define strategy interfaces for behaviors.   |
| Main Benefit | Flexible, reusable, easy to add new strategies|
| Main Drawback | Increases number of classes.|
| Principle Used | Open/Closed Principle (Open for extension, closed for modification.)|

## Real-World Usage Examples
- Payment processing (Credit Card, PayPal, UPI).
- Compression algorithms (Zip, Rar, 7z).
- Sorting algorithms (Bubble sort, Quick sort, Merge sort).
- Authentication strategies (Username/password, OAuth, SSO).

## Bonus Tip

If you find yourself writing a lot of "if-else" or "switch-case" statements to select behavior dynamically, it's a hint that you might need to use the Strategy Pattern.

## Strategy Design Pattern — Mock Interview Questions and Answers
1. What problem does the Strategy Pattern solve?
It solves the problem of having multiple algorithms or behaviors inside a class and changing them dynamically at runtime without modifying the class that uses them.
It promotes Open/Closed Principle — classes are open for extension but closed for modification.

2. In which scenarios would you not use the Strategy Pattern?
You should avoid Strategy Pattern when:

    - The algorithm rarely changes, making the added complexity unnecessary.

    - You don't expect different variations of behavior.

    - You have only one algorithm forever.

    - Runtime selection adds no significant value.
 
3. What are real-world systems or libraries that use the Strategy Pattern internally?
- Sorting algorithms: Java's Comparator and C#'s IComparer use strategy-like behavior.

- Authentication handlers: ASP.NET Core Authentication Middlewares (JWT, OAuth, Cookie Auth) dynamically select strategy for auth.

- Payment gateways: Stripe, Razorpay, etc., allow different payment strategies.

- Compression libraries: Zip, RAR, 7z handling can use Strategy for compressing files.




