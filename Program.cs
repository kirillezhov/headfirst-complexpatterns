﻿using ComplexPatterns.AbstractFactory;
using ComplexPatterns.Adapter;
using ComplexPatterns.Composite;
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
            IQuack redheadDuck = duckFactory.CreateRedheadDuck();
            IQuack duckCall = duckFactory.CreateDuckCall();
            IQuack rubberDuck = duckFactory.CreatRubberDuck();
            IQuack gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\r\nDuck Simulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuack mallardOne = duckFactory.CreateMallardDuck();
            IQuack mallardTwo = duckFactory.CreateMallardDuck();
            IQuack mallardThree = duckFactory.CreateMallardDuck();
            IQuack mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);
            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\r\nDuck Simulator: Whole Flock Simulation");
            simulate(flockOfDucks);

            Console.WriteLine("\r\nDuck Simulator: Mallard Flock Simulation");
            simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked " + QuackCounter.GetQuacks + " times");
        }

        private void simulate(IQuack duck)
        {
            duck.Quack();
        }
    }
}
