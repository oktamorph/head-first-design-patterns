namespace FactoryPattern
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            toppings.Add("Shredded Mozzarella Cheese");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
