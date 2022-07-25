using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class DataSourceDecorator : IDataSource
    {
        private IDataSource _wrapee;

        public DataSourceDecorator(IDataSource source)
        {
            _wrapee = source;
        }

        public virtual string ReadData()
        {
            return _wrapee.ReadData();
        }

        public virtual void WriteData(string data)
        {
            _wrapee.WriteData(data);
        }
    }
}
