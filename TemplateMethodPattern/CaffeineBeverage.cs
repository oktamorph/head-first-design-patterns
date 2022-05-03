namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public virtual void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        public abstract void Brew();
        public abstract void AddCondiments();
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
