using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckCall : IQuackable
    {
        private readonly Observable _observable;
        public DuckCall()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Kwak");
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
