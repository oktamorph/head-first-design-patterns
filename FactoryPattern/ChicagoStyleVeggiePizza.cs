namespace FactoryPattern
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            toppings.Add("Tomatos");
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
