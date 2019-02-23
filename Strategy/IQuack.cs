using ComplexPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Strategy
{
    interface IQuack : IQuackObservable
    {
        void Quack();
    }
}
