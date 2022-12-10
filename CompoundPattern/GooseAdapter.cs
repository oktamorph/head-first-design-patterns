using CompoundPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class GooseAdapter : IQuackable
    {
        private readonly Goose _goose;
        private readonly Observable _observable;
        public GooseAdapter(Goose goose)
        {
            this._goose = goose;
            _observable = new Observable(this);
        }
        public void Quack()
        {
            _goose.Honk();
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