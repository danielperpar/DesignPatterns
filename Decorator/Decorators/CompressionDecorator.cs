using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource source) : base(source){}

        public override string ReadData()
        {
            var compressedData = base.ReadData();
            return Decompress(compressedData);
        }

        public override void WriteData(string data)
        {
            var compressedData = Compress(data);
            base.WriteData(compressedData);
        }

        public string Decompress(string data)
        {
            data = $"Decompressed[{data}]";
            return data;
        }

        public string Compress(string data)
        {
            data = $"Compressed[{data}]";
            return data;
        }
    }
}
