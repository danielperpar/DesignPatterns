using Adapter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Client
{
    internal class RoundHole
    {
        private double _radius;

        public RoundHole(double radius) 
        {
            _radius = radius;
        }

        public bool Fits(IRoundPeg peg)
        {
            return _radius >= peg.GetRadius();
        }
    }
}
