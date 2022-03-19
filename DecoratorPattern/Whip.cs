namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Whip";
        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
