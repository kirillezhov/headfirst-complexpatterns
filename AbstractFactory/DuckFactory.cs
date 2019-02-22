using System;
using System.Collections.Generic;
using System.Text;
using ComplexPatterns.Strategy;

namespace ComplexPatterns.AbstractFactory
{
    class DuckFactory : AbstractDuckFactory
    {
        public override IQuack CreateDuckCall()
        {
            return new DuckCall();
        }

        public override IQuack CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuack CreateRedheadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuack CreatRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
