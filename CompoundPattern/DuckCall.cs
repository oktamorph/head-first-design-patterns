﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
