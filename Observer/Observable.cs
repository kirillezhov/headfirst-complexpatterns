using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Observer
{
    class Observable : IQuackObservable
    {
        List<IObserver> observers = new List<IObserver>();
        IQuackObservable duck;

        public Observable(IQuackObservable duck)
        {
            this.duck = duck;
        }

        public void NotifyObservers()
        {
            IEnumerator enumerator = observers.GetEnumerator();

            while (enumerator.MoveNext())
            {
                IObserver observer = (IObserver)enumerator.Current;
                observer.Update(duck);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
