namespace DesignPatterns.Structural.Composite;

public class Manager(string name, decimal salary) : IEmployee
{
    private readonly string _name = name;
    private readonly decimal _salary = salary;

    public string GetName() => _name;

    public decimal GetSalary() => _salary;

    public string GetRole() => GetType().Name;
}
