namespace DecoratorPattern
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Steamed Milk";
        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
