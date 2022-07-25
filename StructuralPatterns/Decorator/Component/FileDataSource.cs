using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    internal class FileDataSource : IDataSource
    {
        private string _fakeFile = "";

        public string ReadData()
        {
            return _fakeFile;
        }

        public void WriteData(string data)
        {
            Console.WriteLine($"Data to write = {data}");
          _fakeFile += data;
        }
    }
}
