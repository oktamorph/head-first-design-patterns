﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public interface IObserver
    {
        public void Update(IQuackObservable duck);
    }
}
