namespace DesignPatterns.Interfaces
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(string operand);
    }
}
