using ComplexPatterns.Observer;
using ComplexPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Composite
{
    class Flock : IQuack
    {
        List<IQuack> quackers = new List<IQuack>();

        public void Add(IQuack quacker)
        {
            quackers.Add(quacker);
        }

        public void NotifyObservers(){ }

        public void Quack()
        {
            //Iterator pattern
            IEnumerator<IQuack> iterator = quackers.GetEnumerator();

            while (iterator.MoveNext())
            {
                IQuack quacker = iterator.Current;
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            IEnumerator<IQuack> iterator = quackers.GetEnumerator();
            while(iterator.MoveNext())
            {
                IQuack duck = iterator.Current;
                duck.RegisterObserver(observer);
            }
        }
    }
}
