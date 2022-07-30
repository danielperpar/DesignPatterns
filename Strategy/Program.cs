using Strategy.Ctxt;
using Strategy.Strategy;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Client: setting strategy A to context");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine("Client: setting strategy B to context");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}
