using System;
using System.Collections.Generic;
using System.Text;
using ComplexPatterns.Decorator;
using ComplexPatterns.Strategy;

namespace ComplexPatterns.AbstractFactory
{
    class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuack CreateDuckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuack CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuack CreateRedheadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuack CreatRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
