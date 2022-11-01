using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 3, 5 };
            double expected = 4;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            double expected = 3;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfEmptyList()
        {
            List<int> numbers = new List<int> {};
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => {
                average.Mean(numbers);
            });
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 5, 3, 2, 4, 1 };
            double expected = 3;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements() 
        {
            List<int> numbers = new List<int> { 1, 2, 4, 3 };
            double expected = 2.5;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMedianForNoElements() 
        {
            List<int> numbers = new List<int> {};
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => {
                average.Median(numbers);
            });
        }
    }
}
