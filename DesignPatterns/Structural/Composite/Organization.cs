namespace DesignPatterns.Structural.Composite;

public class Organization
{
    private ICollection<IEmployee> _employees = [];

    public void AddEmployee(IEmployee employee) => _employees.Add(employee);

    public decimal GetNetSalaries() => _employees.Select(e => e.GetSalary()).Sum();
}
