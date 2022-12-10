using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers;
        private readonly IQuackObservable _duck;
        public Observable(IQuackObservable duck)
        {
            _observers = new List<IObserver>();
            this._duck = duck;
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}
