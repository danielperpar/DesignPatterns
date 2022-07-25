using System;

namespace FactoryMethod.Products
{
    internal class CargoShip : ITransport
    {
        public void ShipProduct()
        {
            Console.WriteLine("Shipping by CargoShip!");
        }
    }
}