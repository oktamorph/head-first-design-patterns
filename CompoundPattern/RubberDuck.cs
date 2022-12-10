using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class RubberDuck : IQuackable
    {
        private readonly Observable _observable;
               
        public RubberDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
