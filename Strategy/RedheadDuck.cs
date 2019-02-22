using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Strategy
{
    class RedheadDuck : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
