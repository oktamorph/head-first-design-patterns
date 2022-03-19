namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Mocha";
        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
