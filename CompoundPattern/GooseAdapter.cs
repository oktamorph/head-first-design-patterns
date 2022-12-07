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
        public GooseAdapter(Goose goose)
        {
            this._goose = goose;
        }
        public void Quack()
        {
            _goose.Honk();
        }
    }
}
