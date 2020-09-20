using DesignPatterns.Implementations;
using DesignPatterns.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DesignPatterns
{
    class Program
    {
        private static IServiceProvider _services;
        
        private static void BuildServices()
        {
            _services = 
                new ServiceCollection()
                .AddSingleton<ICalculatorFactory, CalculatorFactory>()
                .AddSingleton<ICalculatorBuilder, CalculatorBuilder>()
                .BuildServiceProvider();
        }

        private static void DoFactoryPatternExample()
        {
            var calculatorFactory = _services.GetService<ICalculatorFactory>();

            Console.WriteLine("What type of equation");

            var operand = Console.ReadLine();

            var calculator = calculatorFactory.GetCalculator(operand);

            Console.WriteLine($"10 {operand} 5 = {calculator.Calculate(10, 5)}");
        }

        private static void DoSingletonPatternExample()
        {
            var singletonOne = SingletonClass.GetInstance();
            singletonOne.SomeProperty = 11011;
            Console.WriteLine($"Singleton number 1 = {singletonOne.SomeProperty}");

            var singletonTwo = SingletonClass.GetInstance();
            singletonTwo.SomeProperty = 12345;
            Console.WriteLine($"Singleton number 2 = {singletonTwo.SomeProperty}");

            Console.WriteLine($"In summary: singleton 1 = {singletonOne.SomeProperty} and singleton 2 = {singletonTwo.SomeProperty}... wait what?");
        }

        private static void DoBuilderPatternExample()
        {
            var calculatorBuilder = _services.GetService<ICalculatorBuilder>();

            Console.WriteLine("What type of equation");

            var operand = Console.ReadLine();

            var calculator = calculatorBuilder
                .AddOperand(operand)
                .Build();

            Console.WriteLine($"10 {operand} 5 = {calculator.Calculate(10, 5)}");
        }

        static void Main(string[] args)
        {
            //DoFactoryPatternExample();
            //DoSingletonPatternExample();
            //DoBuilderPatternExample();
        }
    }
}
