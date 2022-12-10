using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class MallardDuck : IQuackable
    {
        private readonly Observable _observable;
        public MallardDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
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
