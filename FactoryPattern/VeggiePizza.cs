namespace FactoryPattern
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
