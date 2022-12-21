using System.Threading;
using Xunit;
using System;

namespace Refactoring.Tests;
public class CurrencyConverterTest
{
    [Fact]
    void WhenConvertToUSDThenReturnCorrectResult() 
    {
        // Arrange
        double amount = 10;
        double expected = 10.9;
        CurrencyConverter currencyConverter = new CurrencyConverter("USD");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvertToEURThenReturnCorrectResult() 
    {
        // Arrange
        double amount = 10;
        double expected = 9.6;
        CurrencyConverter currencyConverter = new CurrencyConverter("EUR");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvertToGBPThenReturnCorrectResult() 
    {
        // Arrange
        double amount = 10;
        double expected = 8.2;
        CurrencyConverter currencyConverter = new CurrencyConverter("GBP");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvertToRUBThenReturnCorrectResult() 
    {
        // Arrange
        double amount = 10;
        double expected = 797.8;
        CurrencyConverter currencyConverter = new CurrencyConverter("RUB");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    void WhenConvertToUnknownCurrencyThenThrowError() 
    {
        // Arrange
        double amount = 10;
        CurrencyConverter currencyConverter = new CurrencyConverter("JPY");

        // Act & Assert
        Assert.Throws<ArgumentException>(() => currencyConverter.ConvertTo(amount)); 

    }
}