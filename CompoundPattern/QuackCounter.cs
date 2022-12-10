using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    internal class QuackCounter : IQuackable
    {
        private readonly IQuackable _duck;
        private static int _numberOfQuacks;
        public QuackCounter(IQuackable duck)
        {
            this._duck = duck;
        }
        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
        }
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }
        public void RegisterObserver(IObserver observer)
        {
            _duck.RegisterObserver(observer);
        }
        public void NotifyObservers()
        {
            _duck.NotifyObservers();
        }
    }
}
