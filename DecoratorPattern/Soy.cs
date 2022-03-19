namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string Description => beverage.Description + ", Soy";
        public override double Cost()
        {
            double cost = beverage.Cost();

            if (beverage.GetSize() == Size.TALL)
                cost += 0.10;
            else if (beverage.GetSize() == Size.GRANDE)
                cost += 0.15;
            else if (beverage.GetSize() == Size.VENTI)
                cost += 0.20;

            return cost;
        }
    }
}
