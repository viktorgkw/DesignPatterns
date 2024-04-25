namespace DesignPatterns.Behavioral.TemplateMethod;

/// <summary>
/// Template method defines the skeleton of how a certain algorithm could be performed, but defers the implementation of those steps to the children classes.
/// </summary>
public abstract class Builder
{
    public void Build()
    {
        Test();
        Lint();
        Assemble();
        Deploy();
    }

    abstract public void Test();

    abstract public void Lint();

    abstract public void Assemble();

    abstract public void Deploy();
}
