using DesignPatterns.Interfaces;

namespace DesignPatterns.Implementations
{
    public class AdditionCalculator : ICalculator
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
