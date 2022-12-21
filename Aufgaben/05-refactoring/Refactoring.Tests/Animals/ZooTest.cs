using Xunit;

namespace Refactoring.Animals.Tests;

public class ZooTest
{
    [Fact]
    void WhenMakeNoiseOfDogThenReturnWoof() 
    {
        // Arrange
        Dog dog = new Dog("Dog");
        string expected = "Dog says woof";

        // Act
        string actual = Zoo.MakeNoise(dog);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenMakeNoiseOfHorseThenReturnNeigh() 
    {
        // Arrange
        Horse horse = new Horse("Horse");
        string expected = "Horse says neigh";

        // Act
        string actual = Zoo.MakeNoise(horse);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenMakeNoiseOfCowThenReturnMooh() 
    {
        // Arrange
        Cow cow = new Cow("Cow");
        string expected = "Cow says mooh";

        // Act
        string actual = Zoo.MakeNoise(cow);

        // Assert
        Assert.Equal(expected, actual);
    }
}