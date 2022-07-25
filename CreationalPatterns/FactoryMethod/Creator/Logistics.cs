using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    internal abstract class Logistics
    {
        public abstract ITransport CreateTransport();

        public void ShipGoods()
        {
            Console.WriteLine("Logistics shipping goods!");
            CreateTransport().ShipProduct();
        }
    }
}
