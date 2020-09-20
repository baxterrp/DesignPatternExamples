using DesignPatterns.Interfaces;

namespace DesignPatterns.Implementations
{
    public class CalculatorBuilder : ICalculatorBuilder
    {
        private string _operand;

        public ICalculatorBuilder AddOperand(string operand)
        {
            _operand = operand;

            return this;
        }

        public ICalculator Build()
        {
            switch (_operand)
            {
                case "+": return new AdditionCalculator();
                case "-": return new SubtractionCalculator();
                case "*": return new MultiplicationCalculator();
                default: return new DivisionCalculator();
            }
        }
    }
}
