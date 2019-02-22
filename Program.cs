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
            simulator.simulate();

            Console.ReadKey();
        }

        private void simulate()
        {
            IQuack mallardDuck = new QuackCounter(new MallardDuck());
            IQuack redheadDuck = new QuackCounter(new RedheadDuck());
            IQuack duckCall = new QuackCounter(new DuckCall());
            IQuack rubberDuck = new QuackCounter(new RubberDuck());
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
