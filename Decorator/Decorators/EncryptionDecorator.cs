using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class EncryptionDecorator : DataSourceDecorator
    {
       
        public EncryptionDecorator(IDataSource source) : base(source){}

        public override string ReadData()
        {
            var encryptedData = base.ReadData();
            return Decrypt(encryptedData);
        }

        public override void WriteData(string data)
        {
            var encryptedData = Encrypt(data);
            base.WriteData(encryptedData);
        }

        private string Encrypt(string data)
        {
            data = $"Encrypted[{data}]";
            return data;
        }

        private string Decrypt(string data)
        {
            data = $"Decrypted[{data}]";
            return data;
        }
    }
}
