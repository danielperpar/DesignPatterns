using Observer.Observers;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    internal class ConcreteObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Observer: subject state changed to {0}", (subject as ConcreteSubject).State);
        }
    }
}
