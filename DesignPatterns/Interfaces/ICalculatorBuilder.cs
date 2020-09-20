namespace DesignPatterns.Interfaces
{
    public interface ICalculatorBuilder
    {
        ICalculatorBuilder AddOperand(string operand);
        ICalculator Build();
    }
}
