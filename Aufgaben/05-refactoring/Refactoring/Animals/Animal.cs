namespace Refactoring.Animals;

public abstract class Animal
{
    public string Name { get; }

    public string Noise { get; }

    public Animal(string name, string noise)
    {
        this.Name = name;
        this.Noise = noise;
    }
}