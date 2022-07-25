using AbstractFactory.Factories;
using AbstractFactory.Factories.Imp;
using System;
using AbstractFactory.FactoryClient;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }   
    }
}
