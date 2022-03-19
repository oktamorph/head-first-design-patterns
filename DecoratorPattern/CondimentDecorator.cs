namespace DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract override string Description { get; }
        public Size GetSize()
        {
            return beverage.GetSize();
        }
    }
}
