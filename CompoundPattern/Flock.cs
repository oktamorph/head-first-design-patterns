using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();
        public void Add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }
        public void Quack()
        {
            IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.Quack();
            }
        }
    }
}
