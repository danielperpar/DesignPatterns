using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.Imp.Chairs
{
    internal class ArtDecoChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("sitting on an Art Deco chair");
        }
    }
}
