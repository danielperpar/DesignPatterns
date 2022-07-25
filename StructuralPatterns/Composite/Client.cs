using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Client
    {
        public void ClientCode1(Component comp)
        {
            Console.WriteLine($"RESULT: {comp.Operation()}\n");
        }

        public void ClientCode2(Component composite, Component component)
        {
            if(composite.IsComposite())
            {
                composite.Add(component);
            }

            Console.WriteLine($"RESULT: {composite.Operation()}\n");
        }
    }
}
