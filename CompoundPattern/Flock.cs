using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Flock : IQuackable
    {
        List<IQuackable> _quackers = new List<IQuackable>();
        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }
        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            foreach (var quacker in _quackers)
            {
                quacker.RegisterObserver(observer);
            }
        }
        public void NotifyObservers() { }
    }
}
