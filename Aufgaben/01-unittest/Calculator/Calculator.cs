using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int multiplicant, int multiplier)
        {
            return multiplicant * multiplier;
        }

        public int Divide(int divident, int divisor) 
        {
            if (divisor == 0) 
            {
                throw new ArgumentException("Division by 0 is not allowed");
            }
            return divident / divisor;
        } 
    }
}
