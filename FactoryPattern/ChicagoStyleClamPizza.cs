namespace FactoryPattern
{
    public class ChicagoStyleClamPizza:Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";

            toppings.Add("Clams");
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
