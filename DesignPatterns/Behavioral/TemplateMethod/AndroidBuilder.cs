namespace DesignPatterns.Behavioral.TemplateMethod;

public class AndroidBuilder : Builder
{
    public override void Test() => Console.WriteLine($"{GetType().Name} -> {nameof(Test)}");

    public override void Lint() => Console.WriteLine($"{GetType().Name} -> {nameof(Lint)}");

    public override void Assemble() => Console.WriteLine($"{GetType().Name} -> {nameof(Assemble)}");

    public override void Deploy() => Console.WriteLine($"{GetType().Name} -> {nameof(Deploy)}");
}
