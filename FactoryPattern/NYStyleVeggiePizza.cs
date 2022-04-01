namespace FactoryPattern
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            toppings.Add("Tomatos");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
