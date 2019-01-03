using Xunit;
using TestsWithDependencyInjection.Web.Models;
using Microsoft.Extensions.DependencyInjection;

namespace TestsWithDependencyInjection.Tests
{
    public class CalculatorTest
    {
        private readonly ICalculator _calculator;

        public CalculatorTest()
        {
            var service = new ServiceCollection();
            service.AddTransient<ICalculator, Calculator>();

            var provider = service.BuildServiceProvider();
            _calculator = provider.GetService<ICalculator>();
        }

        [Fact]
        public void Test_Sum()
        {
            var result = _calculator.Sum(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_Subtract()
        {
            var result = _calculator.Subtract(2, 3);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_Multiply()
        {
            var result = _calculator.Multiply(3, 2);
            Assert.Equal(6, result);
        }
    }
}
