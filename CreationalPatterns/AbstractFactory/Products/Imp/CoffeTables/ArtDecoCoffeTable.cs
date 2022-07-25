using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Imp.CoffeTables
{
    internal class ArtDecoCoffeTable : ICoffeeTable
    {
        public void HoldCoffePot()
        {
            Console.WriteLine("coffe on an Art Deco table");
        }
    }
}
