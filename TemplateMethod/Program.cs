using System;
using TemplateMethod.AbstractClasses;
using TemplateMethod.Client;
using TemplateMethod.ConcreteClasses;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client: using concrete class 1");
            ClientCode.Client(new ConcreteClass1());
            Console.WriteLine();
            Console.WriteLine("Client: using concrete class 2");
            ClientCode.Client(new ConcreteClass2());
        }
    }
}
