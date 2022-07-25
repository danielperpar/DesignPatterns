using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Imp.Sofas
{
    internal class ModernSofa : ISofa
    {
        public void LayOn()
        {
            Console.WriteLine("lying on a Modern sofa");
        }
    }
}
