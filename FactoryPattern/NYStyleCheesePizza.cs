namespace FactoryPattern
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            toppings.Add("Grated Reggiano Cheese");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
