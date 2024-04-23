namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class Paypal : Account
{
    public Paypal(decimal balance) => _balance = balance;
}
