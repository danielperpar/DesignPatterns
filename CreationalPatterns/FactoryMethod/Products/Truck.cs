using System;

namespace FactoryMethod.Products
{
    internal class Truck : ITransport
    {
        public void ShipProduct()
        {
            Console.WriteLine("Shipping by Truck!");
        }
    }
}