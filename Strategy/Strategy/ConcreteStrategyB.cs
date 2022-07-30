using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    internal class ConcreteStrategyB : IStrategy
    {
        public void DoAlgorithm()
        {
            Console.WriteLine("Executing B algorithm");
        }
    }
}
