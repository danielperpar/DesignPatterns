using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    internal interface IFurnitureFactory
    {
        IChair CraftChair();
        ISofa CraftSofa();
        ICoffeeTable CraftCoffeTable();
    }
}
