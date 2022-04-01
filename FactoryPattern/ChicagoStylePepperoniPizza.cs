namespace FactoryPattern
{
    public class ChicagoStylePepperoniPizza:Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            toppings.Add("Pepperonis");
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
