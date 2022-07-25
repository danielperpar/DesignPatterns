using Decorator.Client;
using Decorator.Component;
using Decorator.Decorators;
using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientSystem();
            var dataSource = new FileDataSource();

            var encriptionDecorator = new EncryptionDecorator(dataSource);
            var compressionDecorator = new CompressionDecorator(encriptionDecorator);

            client.ClientCode(compressionDecorator);
        }
    }
}
