using ComplexPatterns.Observer;
using ComplexPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Decorator
{
    class QuackCounter : IQuack
    {
        IQuack duck;
        static int NumberOfQuacks;

        public static int GetQuacks => NumberOfQuacks;

        public QuackCounter(IQuack duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            duck.Quack();
            NumberOfQuacks++;
        }

        public void RegisterObserver(IObserver observer)
        {
            duck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            duck.NotifyObservers();
        }
    }
}
