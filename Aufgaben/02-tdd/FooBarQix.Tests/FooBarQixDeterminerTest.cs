using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        private FooBarQixDeterminer testee = new FooBarQixDeterminer();
    
        [Fact]
        public void WhenNumberDividableBy3ThenReturnTrue() {
            // Arrange
            int numberToDivideBy = 3;

            // Act
            bool actual = testee.IsNumberDividableBy(numberToDivideBy, 6);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void WhenNumberIsNotDividableBy3ThenReturnFalse() {
            // Arrange
            int numberToDivideBy = 3;

            // Act
            bool actual = testee.IsNumberDividableBy(numberToDivideBy, 5);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void WhenNumberIsDividableBy5ThenReturnTrue() {
            // Arrange
            int numberToDivideBy = 5;

            // Act
            bool actual = testee.IsNumberDividableBy(numberToDivideBy, 10);

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void WhenNumberIsNotDividableBy5ThenReturnFalse() {
            // Arrange
            int numberToDivideBy = 5;

            // Act
            bool actual = testee.IsNumberDividableBy(numberToDivideBy, 11);

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void WhenProcessedNumberNotDividableThenReturnNumberAsString() {
            // Arrange
            int numberToCheck = 4;
            string expected = "4";

            // Act
            string actual = testee.ProcessNumber(numberToCheck);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenProcessedNumberDividableBy3ThenReturnFoo() {
            // Arrange
            int numberToCheck = 6;
            string expected = "Foo";

            // Act
            string actual = testee.ProcessNumber(numberToCheck);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenProcessedNumberDividableBy5ThenReturnBar() {
            // Arrange
            int numberToCheck = 10;
            string expected = "Bar";

            // Act
            string actual = testee.ProcessNumber(numberToCheck);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WhenProcessedNumberDividableBy3And5ThenReturnQix() {
            // Arrange
            int numberToCheck = 15;
            string expected = "Qix";

            // Act
            string actual = testee.ProcessNumber(numberToCheck);

            // Assert
            Assert.Equal(expected, actual);
        }
    }

}