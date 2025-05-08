// Component Interface
public interface ICoffee{
    string GetDescription();
    double GetCost();
}

// ConcreteComponent
public class SimpleCoffee : ICoffee
{ 
    public string GetDescription() => "Simple Coffee";
    public double GetCost() => 50.0;  
}

// Decorator
public abstract class CoffeeDecorator : ICoffee{
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee){
        this._coffee = coffee;
    }

    public virtual string GetDescription() => _coffee.GetDescription();
    public virtual double GetCost() => _coffee.GetCost();
}

public class MilkDecorator : CoffeeDecorator{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription() => _coffee.GetDescription() + " Added Milk";
    public override double GetCost() => _coffee.GetCost() + 30.0;
}

public class SugarDecorator : CoffeeDecorator{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    public override string GetDescription() => _coffee.GetDescription() + " Added Sugar";
    public override double GetCost() => _coffee.GetCost() + 20.0;
}

class Program{
    public static void Main(string[] args){
        ICoffee coffee= new SimpleCoffee();
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine(coffee.GetCost());
    }
}