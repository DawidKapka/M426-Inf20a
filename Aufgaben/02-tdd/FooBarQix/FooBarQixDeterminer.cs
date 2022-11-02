namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public bool IsNumberDividableBy(int dividend, int number) {
            return number % dividend == 0;
        }

        public string ProcessNumber(int number) {
            if (IsNumberDividableBy(3, number) && IsNumberDividableBy(5, number))
                return "Qix";
            else if (IsNumberDividableBy(3, number))
                return "Foo";
            else if (IsNumberDividableBy(5, number))
                return "Bar";
            return number.ToString();
        }
    }
}