namespace TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
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
            Console.WriteLine("Steeping the tea");
        }
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
