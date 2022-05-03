namespace TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        public sealed override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
