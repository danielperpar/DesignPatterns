using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Service
{
    internal class SquarePeg
    {
        private double _width;

        public SquarePeg(double width)
        {
            _width = width;
        }

        public double GetWitdh()
        {
            return _width;
        }
    }
}
