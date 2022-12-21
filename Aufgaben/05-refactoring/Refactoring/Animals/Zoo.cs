namespace Refactoring.Animals;

public class Zoo
{
    public static string MakeNoise(Animal animal)
    {
        return animal.Name + " says " + animal.Noise;
    }
}