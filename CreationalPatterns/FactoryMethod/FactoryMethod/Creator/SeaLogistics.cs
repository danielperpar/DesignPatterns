﻿using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator
{
    internal class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new CargoShip();
        }
    }
}
