using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Client
{
    internal class ClientSystem
    {
        public void ClientCode(IDataSource component)
        {
            Console.WriteLine("Client: write data");
            component.WriteData("data to write");

            Console.WriteLine("RESULT data read: " + component.ReadData());
        }
    }
}
