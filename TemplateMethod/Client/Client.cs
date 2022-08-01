using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClasses;

namespace TemplateMethod.Client
{
    internal class ClientCode
    {
        public static void Client(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }
}
