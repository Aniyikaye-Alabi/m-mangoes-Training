namespace GenerateReceipt.Calculator
{
    public class Calculate
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Substract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException();
            }
            return x / y;

        }
    }
}
