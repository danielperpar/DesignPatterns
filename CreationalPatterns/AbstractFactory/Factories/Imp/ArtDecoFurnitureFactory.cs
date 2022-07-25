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
    internal class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        public IChair CraftChair()
        {
            Console.WriteLine("Art Deco chair crafted!");
            return new ArtDecoChair();
        }

        public ICoffeeTable CraftCoffeTable()
        {
            Console.WriteLine("Art Deco coffe table crafted!");
            return new ArtDecoCoffeTable();
        }

        public ISofa CraftSofa()
        {
            Console.WriteLine("Art Deco sofa crafted!");
            return new ArtDecoSofa();
        }
    }
}
