using ComplexPatterns.Observer;
using ComplexPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Adapter
{
    class GooseAdapter : IQuack
    {
        Observable observable;
        Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
            observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            observable.NotifyObservers();
        }

        public void Quack()
        {
            goose.Honk();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observable.RegisterObserver(observer);
        }
    }
}
