using System.Threading;
using Xunit;
using System;

namespace Refactoring.Tests;

public class FibonacciTest
{
    [Fact]
    public void TestFirstFibonacciNumberIsOne()
    {
        // Arrange
        int n = 1;
        int expected = 1;

        // Act
        int actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestBigFibonacciNumber()
    {
        // Arrange
        int n = 45;
        int expected = 1134903170;

        // Act
        int actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNegativeFibonacciNumber() 
    {
        // Arrange
        int n = -2;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Fibonacci.Fib(n));
    }
}