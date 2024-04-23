namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class Account
{
    private Account _successor;
    protected decimal _balance;

    public void SetNext(Account account) => _successor = account;

    public void Pay(decimal amountToPay)
    {
        if (CanPay(amountToPay))
        {
            Console.WriteLine($"Paid {amountToPay:c} using {GetType().Name}.");
        }
        else if (_successor != null)
        {
            Console.WriteLine($"Cannot pay using {GetType().Name}. Proceeding..");
            _successor.Pay(amountToPay);
        }
        else
        {
            throw new Exception("None of the accounts have enough balance");
        }
    }
    private bool CanPay(decimal amount) => _balance >= amount;
}
