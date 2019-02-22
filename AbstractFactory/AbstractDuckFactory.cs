using ComplexPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.AbstractFactory
{
    abstract class AbstractDuckFactory
    {
        public abstract IQuack CreateMallardDuck();
        public abstract IQuack CreateRedheadDuck();
        public abstract IQuack CreateDuckCall();
        public abstract IQuack CreatRubberDuck();
    }
}
