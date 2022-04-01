namespace FactoryPattern
{
    public class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
            pizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");
        }
    }
}
