namespace FactoryPattern
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            toppings.Add("Pepperonis");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
