﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public interface IQuackable : IQuackObservable
    {
        public void Quack();
    }
}
