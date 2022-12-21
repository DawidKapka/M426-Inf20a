namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        } 
        else if (n == 0 || n == 1)
        {
            return n;
        }
        else {
            int lastResult = 0;
            int result = 1;
            for (int i = 0; i < n - 1; i++) {
                result = result + lastResult;
                lastResult = result - lastResult;
            }
            return result;
        }
    }
}