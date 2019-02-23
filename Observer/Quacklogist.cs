using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Observer
{
    class Quacklogist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("Quacklogist: " + duck + " just quacked");
        }
    }
}
