using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal abstract class Component
    {
        public abstract string Operation();

        public abstract bool IsComposite();

        public virtual void Add(Component comp) 
        {   
            throw new NotImplementedException();
        }

        public virtual void Remove(Component comp)
        {
            throw new NotImplementedException();
        }
    }
}
