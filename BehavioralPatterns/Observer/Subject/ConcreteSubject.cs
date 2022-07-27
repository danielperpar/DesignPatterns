using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    internal class ConcreteSubject : ISubject
    {
        public int State { get; set; } = 0;
        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Added an observer");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Removed an observer");
        }

        public void Notify()
        {
            foreach(var obs in _observers)
            {
                obs.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            State = 1;
            Console.WriteLine("Subject: my state changed to {0}", State);
            Notify();
        }
    }
}
