using System;
using System.Collections.Generic;
using System.Text;
using ComplexPatterns.Observer;

namespace ComplexPatterns.Strategy
{
    class DuckCall : IQuack
    {
        Observable observable;

        public DuckCall()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Duck Call";
        }
    }
}
