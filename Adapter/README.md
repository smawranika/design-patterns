## Adapter Design Pattern

#### What is the Adapter Design Pattern?
It allows two incompatible interfaces to work together by wrapping one of them in an adapter class.

> It converts the interface of a class into another interface the client expects.

It’s like a translator between two systems that can’t communicate directly.

## Structure of Adapter Pattern
- Client : The code that needs to use the target interface.
- Target : The expected interface by the client.
- Adaptee : The existing class with a different interface.
- Adapter : A wrapper class that makes the Adaptee fit the Target interface.

## Real-World Example (Simple Analogy)
- You have a laptop with a USB-C port.
- You want to connect it to an HDMI monitor.
- You use a USB-C to HDMI adapter.
    
    The adapter makes two incompatible interfaces (USB-C ↔ HDMI) work together without modifying either side.


## Key Points to Remember

| Aspect | Details|  
| -------- | -------- |  
| Pattern Type | Structural |
| Problem Solved | Make incompatible interfaces work together |
| Analogy | USB-C to HDMI adapter, language translator|
| Code mechanism | Adapter wraps adaptee and exposes expected interface |

## Real-World Usage Examples
- Connecting new code to legacy systems
- Integrating third-party libraries (with incompatible interfaces)
- Making APIs backward compatible
- UI frameworks adapting old widgets to new interfaces
- Payment gateways, logging libraries, file systems

## Advantages
- Reuses existing code without modifying it
- Improves code flexibility and maintainability
- Separates adaptation logic into a clear, isolated class

## Disadvantages
- Adds extra complexity (more layers to understand)
- Can lead to too many small adapter classes if overused

## Adapter Pattern in .NET
- Stream and StreamReader / StreamWriter
- IEnumerable<T> adapted to IList<T>
- IDbCommand adapters for different databases (SQL Server, Oracle, MySQL)
