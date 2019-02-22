using ComplexPatterns.Adapter;
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
            IQuack mallardDuck = new MallardDuck();
            IQuack redheadDuck = new RedheadDuck();
            IQuack duckCall = new DuckCall();
            IQuack rubberDuck = new RubberDuck();
            IQuack gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\r\nDuck Simulator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);
        }

        private void simulate(IQuack duck)
        {
            duck.Quack();
        }
    }
}
