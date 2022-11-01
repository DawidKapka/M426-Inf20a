using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count == 0) 
            {
                throw new ArgumentException("Number list cannot be empty");
            }

            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            numbers.Sort();
            if (numbers.Count == 0)
            {
                throw new ArgumentException("List cannot be empty!");
            }
            else if (numbers.Count % 2 == 0) 
            {
                return ((double)numbers[numbers.Count / 2] + (double)numbers[numbers.Count / 2 - 1]) / 2;
            } 
            else 
            {
                return numbers[(numbers.Count - 1) / 2];
            }
        }
    }
}
