using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexPatterns.Strategy
{
    class DuckCall : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
