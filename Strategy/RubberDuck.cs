using System;
using System.Collections.Generic;
using System.Text;
using ComplexPatterns.Observer;

namespace ComplexPatterns.Strategy
{
    class RubberDuck : IQuack
    {
        Observable observable;

        public RubberDuck()
        {
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}
