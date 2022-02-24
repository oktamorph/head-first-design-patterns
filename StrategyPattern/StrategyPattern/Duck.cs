namespace Chapter01
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;
        protected Duck() { }
        public abstract void Display();
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            QuackBehavior.Quacks();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}
