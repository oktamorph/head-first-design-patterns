namespace FactoryPattern
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            clam = _ingredientFactory.CreateClam();
        }
    }
}
