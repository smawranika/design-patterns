
🌟 What is the Factory Design Pattern?
The Factory Design Pattern is a creational design pattern that creates objects without exposing the creation logic to the client. Instead, it uses a factory method to create the object.

👉 In simple words:

	•	You don’t create objects directly.
	•	You ask the factory to create it for you.
	•	The factory decides which class to instantiate.
	•	The factory returns an object.

🎯 Why Use the Factory Pattern?
To hide the complexity of object creation.

	•	Centralise object creation logic
	•	Make the system easy to maintain and expand
	•	Decouple client code from specific classes


🧩 Real-World Analogy:
Imagine a Car Factory.
You just say "I want a car", and the factory will give you a Sedan, SUV, or Truck based on your request.

You don’t care about:

	•	How the car is built
	•	What exact parts are used
	•	How the engine is assembled

Similarly, in software, the client asks for an object, and the Factory handles the construction.

🏗️ Structure of Factory Pattern

	•	Product: The common interface or abstract class.
	•	ConcreteProduct: The actual classes implementing the Product.
	•	Creator/Factory: The class with a method to create objects of ConcreteProduct.

🔥 Advantages of Factory Pattern:

	•	Reduces coupling between classes and their clients.
	•	Single Responsibility Principle: Factory class handles the instantiation.
	•	Easy to introduce new types without changing much client code.

⚠️ Disadvantages:

	•	Code can become more complex with too many factories.
	•	Might need a lot of factories if not managed properly.
	•	Solution: Abstract Factory Pattern.

🚀 When to Use Factory Pattern?

	•	Use the Factory Method pattern when object creation is complex or depends on conditions.
	•	Use the Factory Method pattern to decouple object creation from usage.
	•	Use the Factory Method pattern to follow the Open/Closed Principle (open for extension, closed for modification).


🙋 Some real-world interview questions based on the Factory Design Pattern:

🌟 What is the Factory Design Pattern? Why is it used?
   
     The Factory Pattern is a creational pattern used to create objects without exposing the creation logic to the client.
     It provides a factory method that decides which subclass to instantiate.
     It improves code maintainability and decouples object creation from usage.

🌟 What is the main problem that the Factory Pattern solves?
   
     It solves the problem of tight coupling between the code that needs objects and the classes of those objects.
     It centralizes object creation and makes adding new types easier without modifying client code.

🌟 Can you give a real-world example of the Factory Pattern?
   
     Vehicle Factory that produces different types of vehicles (Car, Bike, Truck) based on user input.
     The client just asks the factory for a vehicle and uses it without worrying about how it is created.

🌟 How is the Factory Pattern different from simply using a constructor (new)?
   
     Using new couples your code to a specific class.
     Factory Pattern abstracts this and allows creation of new objects without needing the client to know their exact class names, making the system flexible and maintainable.

🌟 How would you modify a Factory if you want to add a new product type without changing the existing code much?
   
     Use Open/Closed Principle — extend the Factory to support new product types through polymorphism or registration mechanisms (e.g., using a dictionary or reflection), without modifying the existing methods heavily.

🌟 What are the potential drawbacks of the Factory Pattern?

     Code can become more complicated if there are too many product types.
     It can violate Single Responsibility Principle if the factory grows too large.
     Managing parameters for different types can become messy if not handled carefully.

🌟 How would you design a Factory when the object creation logic is very complex (e.g., requires different parameters for different products)?
    
     Use a Factory Method Pattern where each subclass of the factory is responsible for creating a specific product.
     Alternatively, use Abstract Factory if multiple families of related products are involved.

🌟 How can you implement a Factory without using if-else or switch-case?

     Register each type dynamically in a Dictionary<string, Func<IProduct>>.
     Use Reflection to instantiate classes based on names.
     Use a Dependency Injection container to resolve the objects.

 🌟 How does the Factory Pattern fit into SOLID principles?
	
      1. Single Responsibility Principle:
        Factory handles object creation
    	  Product classes handle their own behaviour
   
	  2. Open/Closed Principle:
	      New types can be introduced with minimal changes
   
	  3. Dependency Inversion Principle:
	      Clients depend on abstractions (IVehicle) rather than concrete classes (Car, Bike)

