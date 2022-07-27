using Observer.Observer;
using Observer.Subject;
using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserver());

            Console.WriteLine("Client: subject state is {0}", subject.State);
            subject.SomeBusinessLogic();
            Console.WriteLine("Client: subject state is {0}", subject.State);
        }
    }
}
