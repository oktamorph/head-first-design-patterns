using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);
        }
        private void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator: With Composite - Flocks");

            Flock flockOfDucks = new Flock();

            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();

            IQuackable mallardOne = duckFactory.CreateMallardDuck();
            IQuackable mallardTwo = duckFactory.CreateMallardDuck();
            IQuackable mallardThree = duckFactory.CreateMallardDuck();
            IQuackable mallardFour = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("Duck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            Simulate(flockOfMallards);

            Console.WriteLine("The ducks quacked  " + QuackCounter.GetQuacks() + " times");
        }
        private void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
