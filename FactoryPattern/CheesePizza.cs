namespace FactoryPattern
{
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
        }
    }
}
