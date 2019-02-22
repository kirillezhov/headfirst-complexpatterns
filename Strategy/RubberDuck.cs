using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Strategy
{
    class RubberDuck : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
