using System;
using System.Collections.Generic;
using System.Text;
using ComplexPatterns.Observer;

namespace ComplexPatterns.Strategy
{
    class RedheadDuck : IQuack
    {
        Observable observable;

        public RedheadDuck()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Redhead Duck";
        }
    }
}
