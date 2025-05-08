// Target Interface
public interface IPaymentProcessor{
    void Pay(string customer, decimal amount);
}

// Adaptee class
public class LegacyPaymentSystem{
    public void MakePayment(string name, double amount){
        Console.WriteLine($"Legacy payment made for {name}: ${amount}");
    }
}

// Adapter class
public class PaymentAdapter : IPaymentProcessor
{
    private LegacyPaymentSystem legacyPaymentSystem;
    public PaymentAdapter(LegacyPaymentSystem legacyPaymentSystem){
        this.legacyPaymentSystem=legacyPaymentSystem;
    }
    public void Pay(string customer, decimal amount)
    {
        legacyPaymentSystem.MakePayment(customer, (double)amount);
    }
}

// Client Usage
class Program{
    public static void Main(string[] args){
        var legacyPaymentSystem = new LegacyPaymentSystem();
        IPaymentProcessor paymentProcessor= new PaymentAdapter(legacyPaymentSystem);

        paymentProcessor.Pay("John",2000);
    }
}