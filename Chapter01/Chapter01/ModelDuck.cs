﻿namespace Chapter01
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
