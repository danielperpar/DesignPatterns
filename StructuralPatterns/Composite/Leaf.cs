using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf : Component
    {
        public override string Operation() => "Leaf";
        public override bool IsComposite() => false;
    }
}
