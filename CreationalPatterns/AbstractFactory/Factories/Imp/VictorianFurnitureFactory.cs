using AbstractFactory.Products;
using AbstractFactory.Products.Imp.Chairs;
using AbstractFactory.Products.Imp.CoffeTables;
using AbstractFactory.Products.Imp.Sofas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Imp
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CraftChair()
        {
            Console.WriteLine("Victorian chair crafted!");
            return new VictorianChair();
        }

        public ICoffeeTable CraftCoffeTable()
        {
            Console.WriteLine("Victorian coffee table crafted!");
            return new VictorianCoffeTable();
        }

        public ISofa CraftSofa()
        {
            Console.WriteLine("Victorian sofa crafted!");
            return new VictorianSofa();
        }
    }
}
