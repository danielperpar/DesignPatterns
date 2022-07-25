using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Composite : Component
    {
        private List<Component> _children = new();

        public override string Operation()
        {
            var result = "Branch(";
            var i = 0;

            foreach(var component in _children)
            {

                result += component.Operation();
                if (i < _children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";           
        }

        public override bool IsComposite() => true;

        public override void Add(Component comp)
        {
            _children.Add(comp);
        }

        public override void Remove(Component comp)
        {
            _children.Remove(comp);
        }
    }
}
