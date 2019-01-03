namespace TestsWithDependencyInjection.Web.Models
{
    public class Calculator : ICalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public interface ICalculator
    {
        int Sum(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
    }
}
