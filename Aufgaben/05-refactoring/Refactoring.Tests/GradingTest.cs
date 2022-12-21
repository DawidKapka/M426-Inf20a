using System.Threading;
using Xunit;
using System;


namespace Refactoring.Tests;

public class GradingTest 
{
    [Fact]
    void WhenConvert1ToGradeThenReturnA() 
    {
        // Arrange
        int grade = 1;
        char expected = 'A';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

        [Fact]
    void WhenConvert2ToGradeThenReturnB() 
    {
        // Arrange
        int grade = 2;
        char expected = 'B';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvert3ToGradeThenReturnC() 
    {
        // Arrange
        int grade = 3;
        char expected = 'C';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvert4ToGradeThenReturnD() 
    {
        // Arrange
        int grade = 4;
        char expected = 'D';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvert5ToGradeThenReturnE() 
    {
        // Arrange
        int grade = 5;
        char expected = 'E';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvert6ToGradeThenReturnF() 
    {
        // Arrange
        int grade = 6;
        char expected = 'F';

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvertUnknownGradeThenThrowException() 
    {
        // Arrange
        int grade = 7;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Grading.GetLetterGrade(grade));
    }
}