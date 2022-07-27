using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
