namespace DesignPatterns.Behavioral.Visitor;

public interface IAnimal
{
    void Accept(IAnimalOperation operation);
}
