using AbstractFactory.Factories;
using AbstractFactory.Factories.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FactoryClient
{
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("Using Art Deco Factory:");
            ClientCode(new ArtDecoFurnitureFactory());

            Console.WriteLine("Using Modern Factory:");
            ClientCode(new ModernFurnitureFactory());

            Console.WriteLine("Using Victorian Factory:");
            ClientCode(new VictorianFurnitureFactory());
        }

        private void ClientCode(IFurnitureFactory factory)
        {
            factory.CraftChair();
            factory.CraftCoffeTable();
            factory.CraftSofa();
        }
    }
}
