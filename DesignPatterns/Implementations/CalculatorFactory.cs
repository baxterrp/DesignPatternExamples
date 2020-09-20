using DesignPatterns.Interfaces;

namespace DesignPatterns.Implementations
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator GetCalculator(string operand)
        {
            switch (operand)
            {
                case "+": return new AdditionCalculator();
                case "-": return new SubtractionCalculator();
                case "*": return new MultiplicationCalculator();
                default: return new DivisionCalculator();
            }
        }
    }
}
