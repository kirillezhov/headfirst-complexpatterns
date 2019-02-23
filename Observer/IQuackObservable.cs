using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Observer
{
    interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
