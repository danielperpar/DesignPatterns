using System;
using System.Threading;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread process1 = new Thread(() => {
                TestSingleton("foo");
            });

            Thread process2 = new Thread(() => {
                TestSingleton("bar");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine("singleton value={0}", singleton.Value);
        }
    }
}
