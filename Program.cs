using ComplexPatterns.AbstractFactory;
using ComplexPatterns.Adapter;
using ComplexPatterns.Decorator;
using ComplexPatterns.Strategy;
using System;

namespace ComplexPatterns
{
    class DuckSimulator
    {
        static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulator.simulate(duckFactory);

            Console.ReadKey();
        }

        private void simulate(AbstractDuckFactory duckFactory)
        {
            IQuack mallardDuck = duckFactory.CreateMallardDuck();
            IQuack redheadDuck = duckFactory.CreateRedheadDuck();
            IQuack duckCall = duckFactory.CreateDuckCall();
            IQuack rubberDuck = duckFactory.CreatRubberDuck();
            IQuack gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\r\nDuck Simulator: With Decorator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);

            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks + " times");
        }

        private void simulate(IQuack duck)
        {
            duck.Quack();
        }
    }
}
