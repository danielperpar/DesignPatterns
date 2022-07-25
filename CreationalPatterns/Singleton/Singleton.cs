using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed internal class Singleton
    {
        public string Value { get; private set; }

        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        public static Singleton GetInstance(string value)
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}
