using FactoryMethod.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.LogisticsClient
{
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("Launched with RoadLogistics:");
            ClientCode(new RoadLogistics());

            Console.WriteLine("Launched with SeaLogistics:");
            ClientCode(new SeaLogistics());
        }

        private void ClientCode(Logistics logistics)
        {
            logistics.ShipGoods();
        }
    }
}
