using Adapter.Client;
using Adapter.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class SquarePegAdapter : IRoundPeg
    {
        private SquarePeg _squarePeg;

        public SquarePegAdapter(SquarePeg squarePeg)
        {
            _squarePeg = squarePeg;
        }

        public double GetRadius()
        {
            return _squarePeg.GetWitdh() * Math.Sqrt(2) / 2;
        }
    }
}
