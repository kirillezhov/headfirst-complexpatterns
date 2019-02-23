using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Observer
{
    interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
