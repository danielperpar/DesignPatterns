using Adapter.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Service
{
    internal class RoundPeg : IRoundPeg
    {
        private double _radius;

        public RoundPeg(double radius)
        {
            _radius = radius;
        }

        public double GetRadius()
        {
            return _radius;
        }
    }
}
