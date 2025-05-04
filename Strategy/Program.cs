// Step 1: Create the Strategy interface
public interface IPaymentStrategy
{
    void Pay(int amount);
}

// Step 2: Create Concrete Strategy Classes
public class  CreditCardPayment : IPaymentStrategy
{
    public void Pay(int amount){
        Console.WriteLine($"Paid {amount} using credit card");
    }
}

public class  DebitCardPayment : IPaymentStrategy
{
    public void Pay(int amount){
        Console.WriteLine($"Paid {amount} debit card");
    }
}

public class  UPIPayment : IPaymentStrategy
{
    public void Pay(int amount){
        Console.WriteLine($"Paid {amount} using UPI");
    }
}

// Step 3: Create the context class
public class ShoppingCart{
    private IPaymentStrategy paymentStrategy;
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy){
        this.paymentStrategy = paymentStrategy;
    }
    public void Checkout(int amount){
        if(paymentStrategy == null){
            throw new Exception("Payment strategy not set");
        }
        paymentStrategy.Pay(amount);
    }
}

// Step 4: Client Code
class Program{
    public static void Main(string[] args){
        ShoppingCart cart = new();

        cart.SetPaymentStrategy(new UPIPayment());
        cart.Checkout(100);

        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout(200);
    }
}
