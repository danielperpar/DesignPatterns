using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    internal interface IDataSource
    {
        string ReadData();
        void WriteData(string data);
    }
}
