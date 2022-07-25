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
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CraftChair()
        {
            Console.WriteLine("Modern chair crafted!");
            return new ModernChair();
        }

        public ICoffeeTable CraftCoffeTable()
        {
            Console.WriteLine("Modern cofee table crafted!");
            return new ModernCoffeTable();
        }

        public ISofa CraftSofa()
        {
            Console.WriteLine("Modern sofa crafted!");
            return new ModernSofa();
        }
    }
}
