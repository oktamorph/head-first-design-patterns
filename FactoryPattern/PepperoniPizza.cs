namespace FactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            pepperoni = _ingredientFactory.CreatePepperoni();
        }
    }
}
