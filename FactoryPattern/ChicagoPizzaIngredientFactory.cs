namespace FactoryPattern
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }
        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozzarelaCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new EggPlant(), new Spinach(), new BlackOlives() };
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClam()
        {
            return new FrozenClams();
        }
    }
}
